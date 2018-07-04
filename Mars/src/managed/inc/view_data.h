

#ifndef __VIEW_DATA_H__
#define __VIEW_DATA_H__

#include <Elementary.h>
#include "uib_views.h"

/**
 * @brief Forward declaration of model
 */
typedef struct _uib_view_data {
	Evas_Object* win;

	uib_view_context* view1;
	uib_view_context* signup_view;
	uib_view_context* id_find_view;
	uib_view_context* pw_find_view;
	uib_view_context* pw_setting_view;
	uib_view_context* main_view;
	uib_view_context* add_friend_view;
	uib_view_context* chatting_room_view;
	uib_view_context* email_certify_view;
	uib_view_context* chatting_view;
} uib_view_data;

static uib_view_data* view_data;

uib_view_data* get_uib_view_data();

#endif /* __VIEW_DATA_H__ */

