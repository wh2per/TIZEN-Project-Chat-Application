#ifndef _MESSAGE_BUBBLE_H_
#define _MESSAGE_BUBBLE_H_

#include "app_main.h"
#include "define.h"

#if !defined(PACKAGE)
#define PACKAGE "org.example.messagebubbleui"
#endif

#define BUBBLE_TEXT_WIDTH 400
#define NUM_OF_SAMPLE_MESSAGES 10
#define BUBBLE_MAIN_TEXT_STYLE "<font_size=40>%s</font_size>"
#define BUBBLE_SUB_TEXT_STYLE "<font_size=20 font_weight=Bold color=#454545>%s</font_size>"

typedef enum {
   MESSAGE_BUBBLE_NONE = 0,
   MESSAGE_BUBBLE_SENT,
   MESSAGE_BUBBLE_RECEIVE,
   MESSAGE_BUBBLE_LAST
} Message_Bubble_Style;

extern const char *name;
extern Evas_Object *win;
extern Evas_Object *conform;
extern Evas_Object *nf;
extern Evas_Object *main_box;
extern Evas_Object *bubble_scroller;
extern Evas_Object *bubble_box;
extern Evas_Object *input_field_entry;
extern int num_of_bubbles;
extern int total_messages;

void bubble_button_mouse_down_cb(void *data, Evas *e, Evas_Object *obj, void *event_info);

void bubble_button_mouse_up_cb(void *data, Evas *e, Evas_Object *obj, void *event_info);
Evas_Object *create_bubble_table(Evas_Object *parent, Message_Bubble_Style style, const char *main_text, const char *sub_text);
char *get_current_time();
void load_messages();

void bubble_box_resize_cb(Evas *e, Evas_Object *obj, void *event_info);

void send_message();

void send_button_clicked_cb(void *data, Evas_Object *obj, void *event_info);

void entry_focused_cb(void *data, Evas_Object *obj, void *event_info);

void entry_unfocused_cb(void *data, Evas_Object *obj, void *event_info);

Evas_Object *create_input_field_table();
Evas_Object *create_main_view();
void create_base_gui();


#endif
