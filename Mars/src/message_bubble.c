#include "message_bubble.h"
#include "define.h"
#include "message_handler.h"
#include "function.h"



const char *name;
Evas_Object *win;
Evas_Object *conform;
Evas_Object *nf;
Evas_Object *main_box;
Evas_Object *bubble_scroller;
Evas_Object *bubble_box;
Evas_Object *input_field_entry;
int num_of_bubbles;
int total_messages;

void
bubble_button_mouse_down_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
   Evas_Object *bg = (Evas_Object *)data;
   int r, g, b, a;

   if (!bg)
      return;

   evas_object_color_get(bg, &r, &g, &b, &a);
   r *= 0.8;
   g *= 0.8;
   b *= 0.8;

   evas_object_color_set(bg, r, g, b, a);
}

void
bubble_button_mouse_up_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
   Evas_Object *bg = (Evas_Object *)data;
   int r, g, b, a;

   if (!bg)
      return;

   evas_object_color_get(bg, &r, &g, &b, &a);
   r *= 1.25;
   g *= 1.25;
   b *= 1.25;

   evas_object_color_set(bg, r, g, b, a);
}

Evas_Object *
create_bubble_table(Evas_Object *parent, Message_Bubble_Style style, const char *main_text, const char *sub_text)
{
   Evas_Object *bubble_table, *button, *bg, *main_label, *sub_label;
   Eina_Strbuf *strbuf = NULL;
   char *buf = NULL;

   bubble_table = elm_table_add(parent);
   evas_object_size_hint_weight_set(bubble_table, EVAS_HINT_EXPAND, 0.0);
   elm_table_padding_set(bubble_table, ELM_SCALE_SIZE(5), ELM_SCALE_SIZE(5));
   evas_object_show(bubble_table);

   button = elm_button_add(bubble_table);
   elm_object_style_set(button, "transparent");
   evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);

   bg = evas_object_rectangle_add(evas_object_evas_get(button));
   elm_object_content_set(button, bg);
   evas_object_event_callback_add(button, EVAS_CALLBACK_MOUSE_DOWN, bubble_button_mouse_down_cb, bg);
   evas_object_event_callback_add(button, EVAS_CALLBACK_MOUSE_UP, bubble_button_mouse_up_cb, bg);
   evas_object_show(button);

   /* Prepare string buffer for making mark up text */
   strbuf = eina_strbuf_new();
   /* Make a mark up text to string buffer for main label widget */
   eina_strbuf_append_printf(strbuf, BUBBLE_MAIN_TEXT_STYLE, main_text);
   /* Get the string from string buffer. String buffer will be empty. */
   buf = eina_strbuf_string_steal(strbuf);

   main_label = elm_label_add(bubble_table);
   elm_object_text_set(main_label, buf);
   elm_label_wrap_width_set(main_label, ELM_SCALE_SIZE(BUBBLE_TEXT_WIDTH));
   elm_label_line_wrap_set(main_label, ELM_WRAP_MIXED);
   evas_object_size_hint_weight_set(main_label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(main_label, EVAS_HINT_FILL, EVAS_HINT_FILL);
   evas_object_repeat_events_set(main_label, EINA_TRUE);
   evas_object_show(main_label);

   /* Make a mark up text to string buffer for sub label widget */
   eina_strbuf_append_printf(strbuf, BUBBLE_SUB_TEXT_STYLE, sub_text);
   /* Get the string from string buffer. String buffer will be empty. */
   buf = eina_strbuf_string_steal(strbuf);
   /* Free string buffer */
   eina_strbuf_free(strbuf);

   sub_label = elm_label_add(bubble_table);
   elm_object_text_set(sub_label, buf);
   evas_object_size_hint_weight_set(sub_label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_repeat_events_set(sub_label, EINA_TRUE);
   evas_object_show(sub_label);

   switch (style) {
      case MESSAGE_BUBBLE_SENT:
         evas_object_size_hint_align_set(bubble_table, 1.0, 0.0);
         evas_object_size_hint_align_set(sub_label, 1.0, EVAS_HINT_FILL);
         evas_object_color_set(bg, 200, 170, 100, 255);
         elm_table_pack(bubble_table, button, 0, 0, 1, 2);
         elm_table_pack(bubble_table, main_label, 0, 0, 1, 1);
         elm_table_pack(bubble_table, sub_label, 0, 1, 1, 1);
         break;
      case MESSAGE_BUBBLE_RECEIVE:
         evas_object_size_hint_align_set(bubble_table, 0.0, 0.0);
         evas_object_size_hint_align_set(sub_label, 0.0, EVAS_HINT_FILL);
         evas_object_color_set(bg, 100, 170, 200, 255);
         elm_table_pack(bubble_table, button, 0, 0, 1, 2);
         elm_table_pack(bubble_table, main_label, 0, 0, 1, 1);
         elm_table_pack(bubble_table, sub_label, 0, 1, 1, 1);
         break;
      case MESSAGE_BUBBLE_NONE:
      case MESSAGE_BUBBLE_LAST:
      default:
         break;
   }

   return bubble_table;
}

char *
get_current_time()
{
   Eina_Strbuf *strbuf = eina_strbuf_new();
   time_t local_time = time(NULL);
   char buf[200] = {0};
   char *ret = NULL;
   struct tm *time_info = localtime(&local_time);

   strftime(buf, 200, "%l:%M", time_info);
   eina_strbuf_append_printf(strbuf, "%s %s", buf, (time_info->tm_hour >= 12) ? "PM":"AM");
   ret = eina_strbuf_string_steal(strbuf);
   eina_strbuf_free(strbuf);

   return ret;
}

void
load_messages()
{

   Evas_Object *bubble_table;
   bubble_table = create_bubble_table(bubble_box, MESSAGE_BUBBLE_RECEIVE,content_recv_buffer,get_current_time());
   evas_object_show(bubble_table);
   elm_box_pack_start(bubble_box, bubble_table);

   sem_post(&sem_load_message);
/*
   Evas_Object *bubble_table;
   total_messages = NUM_OF_SAMPLE_MESSAGES;
   num_of_bubbles = 0;
   int count = total_messages - 1;

   while (count >= 0) {
      bubble_table = create_bubble_table(bubble_box, count % 2 + 1,
            bubble_messages[count],
            bubble_times[count]);
      evas_object_show(bubble_table);
      elm_box_pack_start(bubble_box, bubble_table);
      num_of_bubbles++;
      count--;
   }
*/

}

void
bubble_box_resize_cb(Evas *e, Evas_Object *obj, void *event_info)
{
   Evas_Coord w, h;


   elm_scroller_child_size_get(bubble_scroller, &w, &h);
   elm_scroller_region_show(bubble_scroller, 0, h, 0, 0);
   evas_object_event_callback_del(bubble_box, EVAS_CALLBACK_RESIZE, bubble_box_resize_cb);
}

void
send_message()
{
	Evas_Object *bubble_table;
	   const char *main_text = NULL;

	   if (!input_field_entry)
	      return;
	   main_text = elm_entry_entry_get(input_field_entry);
	   if (!main_text || (strlen(main_text) == 0))
	      return;

	   bubble_table = create_bubble_table(bubble_box, MESSAGE_BUBBLE_SENT,
	         elm_entry_entry_get(input_field_entry),
	         get_current_time());
	   evas_object_show(bubble_table);
	   elm_box_pack_end(bubble_box, bubble_table);
	   num_of_bubbles++;
	   total_messages++;
	   sendMessage(0,my_index,3,current_room,elm_entry_entry_get(input_field_entry));
	   evas_object_event_callback_add(bubble_box, EVAS_CALLBACK_RESIZE, bubble_box_resize_cb,NULL);
	   elm_entry_entry_set(input_field_entry, "");

}

void
send_button_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
   send_message(data);
}

void
entry_focused_cb(void *data, Evas_Object *obj, void *event_info)
{
   Evas_Object *bg = (Evas_Object *)data;
   evas_object_color_set(bg, 110, 210, 210, 255);
}

void
entry_unfocused_cb(void *data, Evas_Object *obj, void *event_info)
{
   Evas_Object *bg = (Evas_Object *)data;
   evas_object_color_set(bg, 0, 0, 0, 0);
}

Evas_Object *
create_input_field_table()
{
   Evas_Object *table, *button, *bg;

   table = elm_table_add(main_box);
   elm_table_homogeneous_set(table, EINA_TRUE);
   evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, 0.0);
   evas_object_size_hint_align_set(table, EVAS_HINT_FILL, 1.0);
   evas_object_show(table);

   button = elm_button_add(table);
   elm_object_style_set(button, "transparent");
   evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);

   bg = evas_object_rectangle_add(evas_object_evas_get(button));
   elm_object_content_set(button, bg);
   evas_object_color_set(bg, 120, 220, 220, 255);
   evas_object_show(button);
   elm_table_pack(table, button, 0, 0, 3, 2);

   button = elm_button_add(table);
   elm_object_style_set(button, "transparent");
   evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);

   bg = evas_object_rectangle_add(evas_object_evas_get(button));
   elm_object_content_set(button, bg);
   evas_object_color_set(bg, 0, 0, 0, 0);
   evas_object_show(button);
   elm_table_pack(table, button, 0, 0, 2, 2);

   input_field_entry = elm_entry_add(table);
   elm_object_part_text_set(input_field_entry, "elm.guide", "Enter Message");
   evas_object_size_hint_weight_set(input_field_entry, EVAS_HINT_EXPAND, 0.0);
   evas_object_size_hint_align_set(input_field_entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
   evas_object_smart_callback_add(input_field_entry, "focused", entry_focused_cb, bg);
   evas_object_smart_callback_add(input_field_entry, "unfocused", entry_unfocused_cb, bg);
   evas_object_show(input_field_entry);
   elm_table_pack(table, input_field_entry, 0, 0, 2, 2);

   button = elm_button_add(table);
   evas_object_size_hint_weight_set(button, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(button, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_object_text_set(button, "SEND");
   evas_object_smart_callback_add(button, "clicked", send_button_clicked_cb, NULL);
   evas_object_show(button);
   elm_table_pack(table, button, 2, 1, 1, 1);

   return table;
}

Evas_Object *
create_main_view()
{
   Evas_Object *main_scroller, *input_field_table;

   main_scroller = elm_scroller_add(nf);
   elm_scroller_bounce_set(main_scroller, EINA_FALSE, EINA_TRUE);
   evas_object_size_hint_weight_set(main_scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(main_scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);
   evas_object_show(main_scroller);

   main_box = elm_box_add(main_scroller);
   elm_box_align_set(main_box, 0, 0);
   evas_object_size_hint_weight_set(main_box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_show(main_box);

   bubble_scroller = elm_scroller_add(main_box);
   elm_scroller_bounce_set(bubble_scroller, EINA_FALSE, EINA_TRUE);
   evas_object_size_hint_weight_set(bubble_scroller, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(bubble_scroller, EVAS_HINT_FILL, EVAS_HINT_FILL);

   bubble_box = elm_box_add(bubble_scroller);
   elm_box_align_set(bubble_box, 0, 0);
   evas_object_size_hint_weight_set(bubble_box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_show(bubble_box);
   elm_box_padding_set(bubble_box, ELM_SCALE_SIZE(10), ELM_SCALE_SIZE(15));

   elm_object_content_set(bubble_scroller, bubble_box);
   evas_object_show(bubble_scroller);
   elm_box_pack_end(main_box, bubble_scroller);

   input_field_table = create_input_field_table();
   evas_object_show(input_field_table);
   elm_box_pack_end(main_box, input_field_table);
   elm_object_content_set(main_scroller, main_box);

   load_messages();

   return main_scroller;
}




void
create_base_gui()
{
   Evas_Object *main_scroller, *bg;

   /* Window */
   win = elm_win_util_standard_add(PACKAGE, PACKAGE);
   elm_win_conformant_set(win, EINA_TRUE);
   elm_win_autodel_set(win, EINA_TRUE);
   elm_win_indicator_mode_set(win, ELM_WIN_INDICATOR_SHOW);
   elm_app_base_scale_set(1.8);

   if (elm_win_wm_rotation_supported_get(win)) {
      int rots[4] = { 0, 90, 180, 270 };
      elm_win_wm_rotation_available_rotations_set(win, (const int *)(&rots), 4);
   }

   evas_object_smart_callback_add(win, "delete,request", win_del_request_cb, NULL);
   eext_object_event_callback_add(win, EEXT_CALLBACK_BACK, nf_hw_back_cb, NULL);

   /* Conformant */
   conform = elm_conformant_add(win);
   elm_win_indicator_mode_set(win, ELM_WIN_INDICATOR_SHOW);
   elm_win_indicator_opacity_set(win, ELM_WIN_INDICATOR_OPAQUE);
   evas_object_size_hint_weight_set(conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   elm_win_resize_object_add(win, conform);
   evas_object_show(conform);


   /* Naviframe */
   nf = elm_naviframe_add(conform);
   evas_object_size_hint_weight_set(nf, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   elm_object_content_set(conform, nf);
   evas_object_show(nf);

   /* Main view */
   main_scroller = create_main_view();
   elm_naviframe_item_push(nf, "Message Bubble", NULL, NULL, main_scroller, NULL);

   /* Show window after base gui is set up */
   evas_object_show(win);
}
