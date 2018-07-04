/*******************************************************************************
* This file was generated by UI Builder.
* User should hand edit this file.
********************************************************************************/

#include "app_main.h"
#include "view_data.h"
#include "uib_app_manager.h"
#include "uib_views.h"
#include "uib_views_inc.h"
#include "time.h"
#include "function.h"
#include "message_handler.h"
#include "message_bubble.h"
#include "define.h"

typedef struct _uib_chatting_view_control_context {
   /* add your variables here */

} uib_chatting_view_control_context;

typedef struct _uib_chatting_room_view_control_context {
   /* add your variables here */

} uib_chatting_room_view_control_context;

void chatting_room_view_main_friend_list_onitemselected(uib_chatting_room_view_view_context *vc, Evas_Object *obj, void *event_info) {

}

/**
 * @brief the user clicked the button (press/release).
 *
 * @param vc It is context of the view that this event occurred on. It has all of UI components that this view consist of.
 * @param obj It is UI component itself that emits the event signal.
 * @param event_info
 *       event_info is NULL
 *
 */
void chatting_room_view_main_button_onclicked(uib_chatting_room_view_view_context *vc, Evas_Object *obj, void *event_info) {
   obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
   elm_naviframe_item_pop(obj);

}

/**
 * @brief the user clicked the button (press/release).
 *
 * @param vc It is context of the view that this event occurred on. It has all of UI components that this view consist of.
 * @param obj It is UI component itself that emits the event signal.
 * @param event_info
 *       event_info is NULL
 *
 */
void chatting_room_view_chatting_room_button_onclicked(uib_chatting_room_view_view_context *vc, Evas_Object *obj, void *event_info) {
   uib_views_get_instance()->uib_views_current_view_redraw();
}

void chatting_room_view_add_friend_button_onclicked(uib_chatting_room_view_view_context *vc, Evas_Object *obj, void *event_info) {
   obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
   elm_naviframe_item_pop(obj);
   uib_util_push_view("add_friend_view");

}

void chatting_room_view_onuib_view_create(uib_chatting_room_view_view_context *vc, Evas_Object *obj, void *event_info) {

}

void chatting_room_view_make_room_button_onclicked(uib_chatting_room_view_view_context *vc, Evas_Object *obj, void *event_info) {
   uib_util_push_view("chatting_view");
   create_base_gui();
   current_room=1;
   sendMessage(6,my_index,0,1,NULL);
}
