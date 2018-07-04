
/*******************************************************************************
* This file was generated by UI Builder.
* This file will be auto-generated each and everytime you save your project.
* Do not hand edit this file.
********************************************************************************/
				
#ifndef UIB_EMAIL_CERTIFY_VIEW_VIEW_H_
#define UIB_EMAIL_CERTIFY_VIEW_VIEW_H_


#include "g_inc_uib.h"
#include "uib_views.h"

/**
* view context definitions
*/
		
typedef struct _uib_email_certify_view_view_context {

	/* parent evas_object which was parameter of create function */
	Evas_Object *parent;
	/* root container UI Component of this view */
	Evas_Object *root_container;
	/* view class name */
	const char *view_name;
	/* control context to control this view */
	struct _uib_email_certify_view_control_context *cc;

	/* UI Components in this view */
	Evas_Object *grid1;
	Evas_Object *logo_square;
	Evas_Object *email_certify_email_label;
	Evas_Object *email_certify_key_label;
	Evas_Object *email_certify_email_entry;
	Evas_Object *email_certify_key_entry;
	Evas_Object *email_certify_signup_button;
	Evas_Object *email_certify_send_button;
	Evas_Object *email_certify_check_button;
} uib_email_certify_view_view_context;


	
/**
* @brief	Create a new view then return view context of that view.
* 			You can delete view using evas_object_del(vc->evas_object) like other EFL evas objects.
*/
uib_view_context *uib_view_email_certify_view_create(Evas_Object *parent, void *create_callback_param);
uib_view_context *uib_view_email_certify_view_destroy(Evas_Object *parent, void *create_callback_param);

void uib_email_certify_view_config_HD_portrait();
#endif /* UIB_EMAIL_CERTIFY_VIEW_VIEW_H_ */
