/*******************************************************************************
* This file was generated by UI Builder.
* User should hand edit this file.
********************************************************************************/

#include "app_main.h"
#include "view_data.h"
#include "uib_app_manager.h"
#include "uib_views.h"
#include "uib_views_inc.h"

#include "define.h"

typedef struct _uib_main_view_control_context {
	/* add your variables here */

} uib_main_view_control_context;

/**
 * @brief the user clicked the button (press/release).
 *
 * @param vc It is context of the view that this event occurred on. It has all of UI components that this view consist of.
 * @param obj It is UI component itself that emits the event signal.
 * @param event_info
 * 		event_info is NULL
 *
 */
void main_view_add_friend_button_onclicked(uib_main_view_view_context *vc, Evas_Object *obj, void *event_info) {
	/*
	obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
	uib_chatting_view_view_context *temp = evas_object_data_get(obj,"a");

	obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
	evas_object_data_set(obj,"a",vc);
	*/

	uib_util_push_view("add_friend_view");
}

void main_view_onuib_view_create(uib_main_view_view_context *vc, Evas_Object *obj, void *event_info) {
	for(int i=0; i<friend_list_num; i++)
	{
		elm_list_item_append(vc->list1, friend_list[i].name, NULL, NULL, NULL, (void*)i);
	}
	elm_list_go(vc->list1);

}

/**
 * @brief the user clicked the button (press/release).
 *
 * @param vc It is context of the view that this event occurred on. It has all of UI components that this view consist of.
 * @param obj It is UI component itself that emits the event signal.
 * @param event_info
 * 		event_info is NULL
 *
 */
void main_view_main_button_onclicked(uib_main_view_view_context *vc, Evas_Object *obj, void *event_info) {
	uib_views_get_instance()->uib_views_current_view_redraw();
}


/**
 * @brief the user clicked the button (press/release).
 *
 * @param vc It is context of the view that this event occurred on. It has all of UI components that this view consist of.
 * @param obj It is UI component itself that emits the event signal.
 * @param event_info
 * 		event_info is NULL
 *
 */
void main_view_chatting_room_button_onclicked(uib_main_view_view_context *vc, Evas_Object *obj, void *event_info) {
	uib_util_push_view("chatting_room_view");
}
