/*******************************************************************************
* This file was generated by UI Builder.
* User should hand edit this file.
********************************************************************************/

#include "app_main.h"
#include "view_data.h"
#include "uib_app_manager.h"
#include "uib_views.h"
#include "uib_views_inc.h"


	char email[129];
	char key[100];
	int email_ok=0;

typedef struct _uib_email_certify_view_control_context {
	/* add your variables here */

} uib_email_certify_view_control_context;


void email_certify_view_email_certify_send_button_onclicked(uib_email_certify_view_view_context *vc, Evas_Object *obj, void *event_info) {

	//이메일 전송 했나 에러체크
	if(1){
		Evas_Object *popup=elm_popup_add(vc->grid1);
		elm_object_text_set(popup, "Send Successful");
		evas_object_show(popup);
		elm_popup_timeout_set(popup, 1.0);
	}else{
		Evas_Object *popup=elm_popup_add(vc->grid1);
		elm_object_text_set(popup, "Send Error");
		evas_object_show(popup);
		elm_popup_timeout_set(popup, 2.0);
	}
}

void email_certify_view_email_certify_check_button_onclicked(uib_email_certify_view_view_context *vc, Evas_Object *obj, void *event_info) {
	strcpy(email,elm_entry_entry_get(vc->email_certify_email_entry));
	strcpy(key,elm_entry_entry_get(vc->email_certify_key_entry));
	//인증키와 내가 입력한 키가 같으면
	if(1){
		Evas_Object *popup=elm_popup_add(vc->grid1);
		elm_object_text_set(popup, "Certify Success");
		evas_object_show(popup);
		elm_popup_timeout_set(popup, 1.0);
		email_ok =1;
	}
	else{
		Evas_Object *popup=elm_popup_add(vc->grid1);
		elm_object_text_set(popup, "Certify Error");
		evas_object_show(popup);
		elm_popup_timeout_set(popup, 2.0);
	}
}

void email_certify_view_email_certify_signup_button_onclicked(uib_email_certify_view_view_context *vc, Evas_Object *obj, void *event_info) {

	if(email_ok==1){
		Evas_Object *popup=elm_popup_add(vc->grid1);
		elm_object_text_set(popup, "Sign-Up Success");
		evas_object_show(popup);
		elm_popup_timeout_set(popup, 1.0);
		uib_util_push_view("main_view");
	}else{
		Evas_Object *popup=elm_popup_add(vc->grid1);
		elm_object_text_set(popup, "Sign-Up Error");
		evas_object_show(popup);
		elm_popup_timeout_set(popup, 2.0);
	}
}
