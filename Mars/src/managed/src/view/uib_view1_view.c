
		/*******************************************************************************
		* This file was generated by UI Builder.
		* This file will be auto-generated each and everytime you save your project.
		* Do not hand edit this file.
		********************************************************************************/
	#include "g_inc_uib.h"
#include "uib_views.h"
#include "uib_views_inc.h"
#include "uib_app_manager.h"

/* event handler declarations */
void view1_login_button_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_id_search_button_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_pw_search_button_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_signup_button_onclicked(uib_view1_view_context*, Evas_Object*, void*);

uib_view_context* uib_view_view1_create(Evas_Object* parent, void* create_callback_param) {
	elm_win_indicator_mode_set(get_window(parent), ELM_WIN_INDICATOR_SHOW);
	uib_view1_view_context* vc = calloc(1, sizeof(uib_view1_view_context));
	vc->parent = parent;
	vc->view_name = "view1";
	if (!vc->grid1) {
		vc->grid1= elm_grid_add(parent);
		vc->root_container = vc->grid1;
	}
	uib_app_manager_get_instance()->add_view_context((uib_view_context*)vc);
	uib_views_get_instance()->set_targeted_view(vc->view_name);

	//bind event handler
	evas_object_smart_callback_add(vc->login_button, "clicked", (Evas_Smart_Cb)view1_login_button_onclicked, vc);
	evas_object_smart_callback_add(vc->id_search_button, "clicked", (Evas_Smart_Cb)view1_id_search_button_onclicked, vc);
	evas_object_smart_callback_add(vc->pw_search_button, "clicked", (Evas_Smart_Cb)view1_pw_search_button_onclicked, vc);
	evas_object_smart_callback_add(vc->signup_button, "clicked", (Evas_Smart_Cb)view1_signup_button_onclicked, vc);


	evas_object_data_set(vc->root_container, KEY_VIEW_CONTEXT, vc);
	evas_object_event_callback_add(vc->root_container, EVAS_CALLBACK_DEL, (Evas_Object_Event_Cb)uib_views_destroy_callback, vc);
	uib_views_create_callback(vc, evas_object_evas_get(vc->root_container), vc->root_container, create_callback_param);

	return (uib_view_context*)vc;
}
void uib_view1_config_HD_portrait() {
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");
	if(vc->grid1) {
		elm_grid_clear(vc->grid1, EINA_FALSE);
		evas_object_size_hint_align_set(vc->grid1, -1.0, -1.0);		evas_object_size_hint_weight_set(vc->grid1, 1.0, 1.0);		elm_grid_size_set(vc->grid1, 1000, 1000);
		if (!vc->id_entry) {
			vc->id_entry= elm_entry_add(vc->grid1);
		}
		if(vc->id_entry) {
			elm_entry_single_line_set(vc->id_entry, EINA_TRUE);
			elm_entry_password_set(vc->id_entry, EINA_FALSE);
			elm_entry_editable_set(vc->id_entry, EINA_TRUE);
			elm_entry_context_menu_disabled_set(vc->id_entry, EINA_FALSE);
			elm_entry_scrollable_set(vc->id_entry, EINA_FALSE);
			evas_object_size_hint_align_set(vc->id_entry, -1.0, -1.0);
			evas_object_size_hint_weight_set(vc->id_entry, 1.0, 1.0);
			elm_object_disabled_set(vc->id_entry, EINA_FALSE);
			evas_object_show(vc->id_entry);
		}
		if (!vc->logo_square) {
			vc->logo_square = elm_image_add(vc->grid1);
		}
		if(vc->logo_square) {
			elm_image_smooth_set(vc->logo_square, EINA_TRUE);
			elm_image_no_scale_set(vc->logo_square, EINA_FALSE);
			elm_image_resizable_set(vc->logo_square, EINA_TRUE, EINA_TRUE);
			elm_image_aspect_fixed_set(vc->logo_square, EINA_FALSE);
			elm_image_fill_outside_set(vc->logo_square, EINA_FALSE);
			elm_image_editable_set(vc->logo_square, EINA_FALSE);
			evas_object_size_hint_align_set(vc->logo_square, -1.0, -1.0);
			evas_object_size_hint_weight_set(vc->logo_square, 1.0, 1.0);
			evas_object_show(vc->logo_square);
		}
		if (!vc->login_button) {
			vc->login_button = elm_button_add(vc->grid1);
		}
		if (vc->login_button) {
			evas_object_size_hint_align_set(vc->login_button, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->login_button, 1.0, 1.0);			elm_object_text_set(vc->login_button,_UIB_LOCALE("Login"));
			elm_object_style_set(vc->login_button,"default");
			evas_object_show(vc->login_button);
		}
		if (!vc->pw_entry) {
			vc->pw_entry= elm_entry_add(vc->grid1);
		}
		if(vc->pw_entry) {
			elm_entry_single_line_set(vc->pw_entry, EINA_TRUE);
			elm_entry_password_set(vc->pw_entry, EINA_TRUE);
			elm_entry_editable_set(vc->pw_entry, EINA_TRUE);
			elm_entry_context_menu_disabled_set(vc->pw_entry, EINA_FALSE);
			elm_entry_scrollable_set(vc->pw_entry, EINA_FALSE);
			evas_object_size_hint_align_set(vc->pw_entry, -1.0, -1.0);
			evas_object_size_hint_weight_set(vc->pw_entry, 1.0, 1.0);
			elm_object_disabled_set(vc->pw_entry, EINA_FALSE);
			evas_object_show(vc->pw_entry);
		}
		if (!vc->id_label) {
			vc->id_label = elm_label_add(vc->grid1);
		}
		if(vc->id_label) {
			evas_object_size_hint_align_set(vc->id_label, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->id_label, 1.0, 1.0);			elm_object_text_set(vc->id_label,_UIB_LOCALE("ID"));
			elm_label_line_wrap_set(vc->id_label, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->id_label,0);
			elm_label_ellipsis_set(vc->id_label, EINA_FALSE);
			evas_object_show(vc->id_label);
		}
		if (!vc->pw_label) {
			vc->pw_label = elm_label_add(vc->grid1);
		}
		if(vc->pw_label) {
			evas_object_size_hint_align_set(vc->pw_label, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->pw_label, 1.0, 1.0);			elm_object_text_set(vc->pw_label,_UIB_LOCALE("PW"));
			elm_label_line_wrap_set(vc->pw_label, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->pw_label,0);
			elm_label_ellipsis_set(vc->pw_label, EINA_FALSE);
			evas_object_show(vc->pw_label);
		}
		if (!vc->id_search_button) {
			vc->id_search_button = elm_button_add(vc->grid1);
		}
		if (vc->id_search_button) {
			evas_object_size_hint_align_set(vc->id_search_button, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->id_search_button, 1.0, 1.0);			elm_object_text_set(vc->id_search_button,_UIB_LOCALE("Search Id"));
			elm_object_style_set(vc->id_search_button,"default");
			evas_object_show(vc->id_search_button);
		}
		if (!vc->pw_search_button) {
			vc->pw_search_button = elm_button_add(vc->grid1);
		}
		if (vc->pw_search_button) {
			evas_object_size_hint_align_set(vc->pw_search_button, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->pw_search_button, 1.0, 1.0);			elm_object_text_set(vc->pw_search_button,_UIB_LOCALE("Search Password"));
			elm_object_style_set(vc->pw_search_button,"default");
			evas_object_show(vc->pw_search_button);
		}
		if (!vc->signup_button) {
			vc->signup_button = elm_button_add(vc->grid1);
		}
		if (vc->signup_button) {
			evas_object_size_hint_align_set(vc->signup_button, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->signup_button, 1.0, 1.0);			elm_object_text_set(vc->signup_button,_UIB_LOCALE("Sign  - up"));
			elm_object_style_set(vc->signup_button,"default");
			evas_object_show(vc->signup_button);
		}
		if (!vc->autologin_check) {
			vc->autologin_check = elm_check_add(vc->grid1);
		}
		if(vc->autologin_check) {
			evas_object_size_hint_align_set(vc->autologin_check, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->autologin_check, 1.0, 1.0);			elm_object_text_set(vc->autologin_check,_UIB_LOCALE("auto-login"));
			elm_object_style_set(vc->autologin_check,"default");
			elm_check_state_set(vc->autologin_check, EINA_FALSE);
			evas_object_show(vc->autologin_check);
		}
		elm_grid_pack(vc->grid1, vc->id_entry, 217, 444, 442, 64);		elm_grid_pack(vc->grid1, vc->logo_square, 83, 49, 815, 321);		elm_grid_pack(vc->grid1, vc->login_button, 700, 446, 254, 153);		elm_grid_pack(vc->grid1, vc->pw_entry, 216, 534, 442, 64);		elm_grid_pack(vc->grid1, vc->id_label, 15, 442, 185, 60);		elm_grid_pack(vc->grid1, vc->pw_label, 14, 534, 185, 60);		elm_grid_pack(vc->grid1, vc->id_search_button, 65, 632, 396, 67);		elm_grid_pack(vc->grid1, vc->pw_search_button, 481, 632, 396, 67);		elm_grid_pack(vc->grid1, vc->signup_button, 65, 718, 390, 67);		elm_grid_pack(vc->grid1, vc->autologin_check, 481, 718, 396, 67);		evas_object_show(vc->grid1);
	}
}

