S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: chattingapp
PID: 5172
Date: 2016-09-26 21:26:43+0900
Executable File Path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x84

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb35250f4, esi = 0xb7d2acf8
ebp = 0xbf8b1ed8, esp = 0xbf8b1eb0
eax = 0x80056cb8, ebx = 0xb35272a0
ecx = 0x00000000, edx = 0x00000002
eip = 0xb3522c5d

Memory Information
MemTotal:      123 KB
MemFree:        23 KB
Buffers:         3 KB
Cached:     200248 KB
VmPeak:     116416 KB
VmSize:     116416 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23072 KB
VmRSS:       23072 KB
VmData:      51868 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33536 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 5172 TID = 5172
5172 5173 5212 5216 5217 5220 

Maps Information
b1b02000 b1b09000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1b4b000 b1b63000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b64000 b1b6b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b236d000 b2377000 r-xp /usr/lib/libfeedback.so.0.1.4
b237d000 b2389000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b238a000 b23ab000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b23b0000 b23b1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b23b2000 b23b7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b23b8000 b23ba000 r-xp /usr/lib/libxcb-present.so.0.0.0
b23bb000 b23bd000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b23be000 b23ca000 r-xp /usr/lib/libdrm.so.2.4.0
b23cb000 b23d5000 r-xp /usr/lib/libtbm.so.1.0.0
b23d6000 b23eb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b23ec000 b23fe000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2d00000 b2d01000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d02000 b2d05000 r-xp /usr/lib/libdri2.so.0.0.0
b2d06000 b2d07000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3509000 b3512000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3513000 b3527000 r-xp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
b362f000 b3635000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3636000 b377a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3790000 b3791000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3792000 b3793000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3794000 b3797000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3798000 b379b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b379c000 b37d5000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41d8000 b41e3000 r-xp /lib/libnss_files-2.20-2014.11.so
b41e5000 b41f0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f2000 b4209000 r-xp /lib/libnsl-2.20-2014.11.so
b420d000 b4215000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4217000 b423b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b423c000 b423d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b423e000 b4241000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4242000 b4249000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b424a000 b4254000 r-xp /usr/lib/libsensord-share.so
b4255000 b4271000 r-xp /usr/lib/libsensor.so.1.2.0
b4273000 b427c000 r-xp /usr/lib/libappcore-common.so.1.1
b427f000 b4281000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4296000 b4298000 r-xp /usr/lib/libXau.so.6.0.0
b4299000 b42bb000 r-xp /usr/lib/libxcb.so.1.1.0
b42bd000 b42c6000 r-xp /lib/libcrypt-2.20-2014.11.so
b42ef000 b42f1000 r-xp /usr/lib/libiri.so
b42f2000 b4318000 r-xp /lib/libexpat.so.1.5.2
b431a000 b4385000 r-xp /usr/lib/libssl.so.1.0.0
b438b000 b4397000 r-xp /usr/lib/libethumb.so.1.13.0
b4398000 b439c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b439d000 b45ee000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b69000 b5b79000 r-xp /usr/lib/libXi.so.6.1.0
b5b7a000 b5b7c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b7d000 b5b83000 r-xp /usr/lib/libXtst.so.6.1.0
b5b84000 b5b8e000 r-xp /usr/lib/libXrender.so.1.3.0
b5b8f000 b5b98000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b9a000 b5b9c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b9d000 b5ba2000 r-xp /usr/lib/libXfixes.so.3.1.0
b5ba3000 b5bb5000 r-xp /usr/lib/libXext.so.6.4.0
b5bb6000 b5bb8000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bb9000 b5bbb000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bbd000 b5cff000 r-xp /usr/lib/libX11.so.6.3.0
b5d03000 b5d0d000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d0e000 b5d24000 r-xp /usr/lib/libudev.so.1.6.0
b5d27000 b5d2b000 r-xp /lib/libattr.so.1.1.0
b5d2c000 b5d5b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d5d000 b5d63000 r-xp /usr/lib/libffi.so.6.0.2
b5d64000 b5d87000 r-xp /lib/libz.so.1.2.8
b5d88000 b5d8b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d8c000 b5ee8000 r-xp /usr/lib/libxml2.so.2.9.2
b5eee000 b5fd5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe2000 b5fe5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fe6000 b6008000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6009000 b601d000 r-xp /lib/libresolv-2.20-2014.11.so
b6021000 b6045000 r-xp /usr/lib/liblzma.so.5.0.3
b6046000 b6048000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b604a000 b6054000 r-xp /usr/lib/libembryo.so.1.13.0
b6055000 b607e000 r-xp /usr/lib/libpng12.so.0.50.0
b607f000 b60c8000 r-xp /usr/lib/libjpeg.so.8.0.2
b60d9000 b60e0000 r-xp /lib/librt-2.20-2014.11.so
b60e2000 b6101000 r-xp /usr/lib/libector.so.1.13.0
b6104000 b6131000 r-xp /usr/lib/liblua-5.1.so
b6132000 b61c2000 r-xp /usr/lib/libfreetype.so.6.11.3
b61c6000 b6204000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6205000 b621b000 r-xp /usr/lib/libfribidi.so.0.3.1
b621c000 b6275000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6278000 b62c3000 r-xp /lib/libm-2.20-2014.11.so
b62c5000 b62d7000 r-xp /usr/lib/libeio.so.1.13.0
b62d8000 b62db000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62dc000 b62e2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62e3000 b6306000 r-xp /usr/lib/libefreet.so.1.13.0
b6309000 b6334000 r-xp /usr/lib/libeldbus.so.1.13.0
b6335000 b6369000 r-xp /usr/lib/libecore_con.so.1.13.0
b636b000 b6374000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6375000 b637e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b637f000 b6392000 r-xp /usr/lib/libeo.so.1.13.0
b6394000 b63a7000 r-xp /usr/lib/libecore_input.so.1.13.0
b63a8000 b63af000 r-xp /usr/lib/libecore_file.so.1.13.0
b63b0000 b63d3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63d4000 b6400000 r-xp /usr/lib/libeet.so.1.13.0
b6409000 b6474000 r-xp /usr/lib/libeina.so.1.13.0
b6477000 b648e000 r-xp /usr/lib/libefl.so.1.13.0
b6490000 b65f7000 r-xp /usr/lib/libicuuc.so.51.1
b6605000 b6811000 r-xp /usr/lib/libicui18n.so.51.1
b6819000 b6868000 r-xp /usr/lib/libecore_x.so.1.13.0
b686a000 b6884000 r-xp /lib/libgcc_s-4.9.so.1
b6886000 b688a000 r-xp /lib/libcap.so.2.21
b688b000 b68d1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d2000 b68d9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68db000 b692d000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b692f000 b6aba000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6abf000 b6b8d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b90000 b6b94000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b95000 b6ba4000 r-xp /usr/lib/libvconf.so.0.2.45
b6ba5000 b6ba8000 r-xp /usr/lib/libvasum.so.0.3.1
b6ba9000 b6bac000 r-xp /usr/lib/libttrace.so.1.1
b6bae000 b6bb2000 r-xp /usr/lib/libiniparser.so.0
b6bb3000 b6be3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6be4000 b6bed000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bee000 b6c13000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c14000 b6c24000 r-xp /usr/lib/libunwind.so.8.0.1
b6c2e000 b6ddc000 r-xp /lib/libc-2.20-2014.11.so
b6de4000 b6f27000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f29000 b6f81000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f82000 b6fb6000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fb9000 b708d000 r-xp /usr/lib/libedje.so.1.13.0
b7090000 b70bc000 r-xp /usr/lib/libecore.so.1.13.0
b70cd000 b72f3000 r-xp /usr/lib/libevas.so.1.13.0
b731b000 b7333000 r-xp /lib/libpthread-2.20-2014.11.so
b7337000 b76b1000 r-xp /usr/lib/libelementary.so.1.13.0
b76d1000 b76d5000 r-xp /usr/lib/libsmack.so.1.0.0
b76d6000 b76df000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e0000 b76e3000 r-xp /usr/lib/libdlog.so.0.0.0
b76e4000 b76e9000 r-xp /usr/lib/libbundle.so.0.1.22
b76ea000 b76ed000 r-xp /lib/libdl-2.20-2014.11.so
b76ef000 b7714000 r-xp /usr/lib/libaul.so.0.1.0
b7717000 b7719000 r-xp /usr/lib/libappsvc.so.0.1.0
b771a000 b771f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7720000 b7727000 r-xp /usr/lib/libappcore-efl.so.1.1
b7729000 b772e000 r-xp /usr/lib/libsys-assert.so
b7731000 b7732000 r-xp [vdso]
b7732000 b7754000 r-xp /lib/ld-2.20-2014.11.so
b7756000 b775e000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5172)
Call Stack Count: 22
 0: view1_id_search_button_onclicked + 0x3d (0xb3522c5d) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xfc5d
 1: (0xb7156116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb638d319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb638ad63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71589e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7409404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb703cf39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7043a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb703dfdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb703e4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb703e68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70a3702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb709d055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70a61b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70a6587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb74ff22d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7723dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb771cc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: app_run + 0x1cb (0xb352303b) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x1003b
19: main + 0x258 (0xb3524f88) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x11f88
20: (0xb7758148) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xb7758148
21: __libc_start_main + 0xde (0xb6c45e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.chattingapp
Package ID : org.example.chattingapp
Version: 1.0.0
Package Type: tpk
App Name: chattingapp
App ID: org.example.chattingapp
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ckage_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
09-26 21:26:24.888+0900 D/AUL_AMD ( 2879): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2984 is org.tizen.homescreen
09-26 21:26:24.888+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2984 : 0
09-26 21:26:24.888+0900 D/AUL     ( 3056): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
09-26 21:26:24.888+0900 D/DATA_PROVIDER_MASTER( 3030): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2984 is resumed
09-26 21:26:24.888+0900 D/DATA_PROVIDER_MASTER( 3030): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
09-26 21:26:24.888+0900 E/DATA_PROVIDER_MASTER( 3030): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
09-26 21:26:25.148+0900 D/cluster-view( 2984): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
09-26 21:26:25.148+0900 D/cluster-view( 2984): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[720.00, 0.00]
09-26 21:26:25.148+0900 D/cluster-view( 2984): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -720.00 (page:1)
09-26 21:26:25.148+0900 D/test-log( 2984): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 2
09-26 21:26:25.148+0900 D/test-log( 2984): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 2
09-26 21:26:25.148+0900 D/cluster-view( 2984): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 2 page focused
09-26 21:26:25.148+0900 D/cluster-home( 2984): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[2] focused
09-26 21:26:25.498+0900 E/VCONF   ( 4851): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
09-26 21:26:25.498+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
09-26 21:26:25.498+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
09-26 21:26:25.498+0900 E/VCONF   ( 4851): vconf.c: vconf_get_str(2891) > vconf_get_str(4851) : db/menu_widget/language error
09-26 21:26:25.498+0900 E/PKGMGR_INFO( 4851): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
09-26 21:26:25.498+0900 D/PKGMGR_INFO( 4851): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.498+0900 D/PKGMGR_INFO( 4851): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.518+0900 E/VCONF   ( 4851): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
09-26 21:26:25.518+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
09-26 21:26:25.518+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
09-26 21:26:25.518+0900 E/VCONF   ( 4851): vconf.c: vconf_get_str(2891) > vconf_get_str(4851) : db/menu_widget/language error
09-26 21:26:25.518+0900 E/PKGMGR_INFO( 4851): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
09-26 21:26:25.518+0900 D/PKGMGR_INFO( 4851): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.518+0900 D/PKGMGR_INFO( 4851): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.528+0900 E/VCONF   ( 4851): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
09-26 21:26:25.528+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
09-26 21:26:25.528+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
09-26 21:26:25.528+0900 E/VCONF   ( 4851): vconf.c: vconf_get_str(2891) > vconf_get_str(4851) : db/menu_widget/language error
09-26 21:26:25.528+0900 E/PKGMGR_INFO( 4851): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
09-26 21:26:25.528+0900 D/PKGMGR_INFO( 4851): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.528+0900 D/PKGMGR_INFO( 4851): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.548+0900 E/VCONF   ( 4851): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
09-26 21:26:25.548+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
09-26 21:26:25.548+0900 E/VCONF   ( 4851): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
09-26 21:26:25.548+0900 E/VCONF   ( 4851): vconf.c: vconf_get_str(2891) > vconf_get_str(4851) : db/menu_widget/language error
09-26 21:26:25.548+0900 E/PKGMGR_INFO( 4851): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
09-26 21:26:25.708+0900 D/LAUNCH  ( 5183): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
09-26 21:26:25.708+0900 D/PKGMGR_INFO( 5183): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.708+0900 D/PKGMGR_INFO( 5183): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
09-26 21:26:25.708+0900 D/AUL     ( 5183): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 5183 is org.tizen.crash-popup
09-26 21:26:25.878+0900 D/APP_CORE( 5183): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
09-26 21:26:25.878+0900 D/APP_CORE( 5183): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
09-26 21:26:25.878+0900 D/APP_CORE( 5183): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
09-26 21:26:25.888+0900 D/APP_CORE( 5183): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
09-26 21:26:25.888+0900 D/AUL     ( 5183): app_sock.c: __create_server_sock(156) > pg path - already exists
09-26 21:26:25.888+0900 D/APP_CORE( 5183): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb772d520
09-26 21:26:25.888+0900 D/LAUNCH  ( 5183): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
09-26 21:26:25.938+0900 D/APP_CORE( 5183): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
09-26 21:26:25.938+0900 W/E17_EXTRA_MODULES( 2793): e_mod_comp.c: _e_mod_comp_win_add(1727) > [CW Creating Fail!!(Attributes get)] Win:02600002, BD:(nil), POP:(nil), MENU:(nil)
09-26 21:26:25.948+0900 D/LAUNCH  ( 5183): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
09-26 21:26:25.968+0900 D/APP_CORE( 5183): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
09-26 21:26:26.578+0900 E/RESOURCED( 2954): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
09-26 21:26:28.308+0900 D/RESOURCED( 2954): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
09-26 21:26:28.308+0900 I/RESOURCED( 2954): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
09-26 21:26:28.308+0900 D/RESOURCED( 2954): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
09-26 21:26:28.308+0900 I/RESOURCED( 2954): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
09-26 21:26:28.998+0900 E/EFL     ( 5183): eldbus<5183> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-LHO0YFDrlg: Connection refused
09-26 21:26:28.998+0900 E/EFL     ( 5183): <5183> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
09-26 21:26:28.998+0900 E/EFL     ( 5183): elementary<5183> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
09-26 21:26:28.998+0900 D/APP_CORE( 5183): appcore.c: __aul_handler(587) > [APP 5183]     AUL event: AUL_START
09-26 21:26:28.998+0900 I/APP_CORE( 5183): appcore-efl.c: __do_app(496) > [APP 5183] Event: RESET State: CREATED
09-26 21:26:28.998+0900 D/APP_CORE( 5183): appcore-efl.c: __do_app(527) > [APP 5183] RESET
09-26 21:26:28.998+0900 D/LAUNCH  ( 5183): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
09-26 21:26:28.998+0900 D/APP_CORE( 5183): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
09-26 21:26:28.998+0900 D/APP_CORE( 5183): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 21:26:28.998+0900 E/SYSPOPUP( 5183): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
09-26 21:26:28.998+0900 E/SYSPOPUP( 5183): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
09-26 21:26:28.998+0900 E/SYSPOPUP( 5183): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
09-26 21:26:28.998+0900 D/LAUNCH  ( 5183): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
09-26 21:26:28.998+0900 D/APP_CORE( 5183): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
09-26 21:26:29.028+0900 D/AUL     ( 5183): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
09-26 21:26:29.028+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 22
09-26 21:26:29.028+0900 W/AUL_AMD ( 2879): amd_request.c: __request_handler(1056) > app status : 5
09-26 21:26:29.028+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(5183) status(5)
09-26 21:26:29.028+0900 D/APP_CORE( 5183): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
09-26 21:26:29.028+0900 E/EFL     ( 5183): eo<5183> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
09-26 21:26:29.028+0900 E/EFL     ( 5183): eo<5183> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
09-26 21:26:35.418+0900 E/CAPI_NETWORK_WIFI( 2958): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
09-26 21:26:35.418+0900 E/INDICATOR( 2958): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
09-26 21:26:35.418+0900 E/INDICATOR( 2958): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
09-26 21:26:35.418+0900 E/INDICATOR( 2958): 
09-26 21:26:42.598+0900 D/test-log( 2984): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
09-26 21:26:42.598+0900 D/test-log( 2984): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
09-26 21:26:42.688+0900 D/test-log( 2984): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
09-26 21:26:42.688+0900 D/test-log( 2984): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
09-26 21:26:42.688+0900 D/test-log( 2984): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
09-26 21:26:42.688+0900 D/test-log( 2984): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
09-26 21:26:42.688+0900 D/test-log( 2984): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[415.00][157.00] to[415.00][157.00]!
09-26 21:26:42.688+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
09-26 21:26:42.688+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20004c 
09-26 21:26:42.688+0900 D/cluster-home( 2984): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
09-26 21:26:42.698+0900 D/cluster-home( 2984): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
09-26 21:26:42.698+0900 D/AUL     ( 2984): service.c: __set_bundle(186) > __set_bundle
09-26 21:26:42.698+0900 D/AUL     ( 2984): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
09-26 21:26:42.698+0900 D/AUL     ( 2984): service.c: __set_bundle(186) > __set_bundle
09-26 21:26:42.698+0900 D/AUL     ( 2984): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.chattingapp - no result
09-26 21:26:42.698+0900 D/AUL     ( 2984): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.chattingapp
09-26 21:26:42.698+0900 D/AUL     ( 2984): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
09-26 21:26:42.698+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 0
09-26 21:26:42.698+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.chattingapp
09-26 21:26:42.698+0900 W/AUL_AMD ( 2879): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
09-26 21:26:42.698+0900 W/AUL_AMD ( 2879): amd_launch.c: _start_app(2233) > caller pid : 2984
09-26 21:26:42.708+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
09-26 21:26:42.708+0900 D/AUL_AMD ( 2879): amd_key.c: _key_grab(243) > _key_grab, win : a00002
09-26 21:26:42.708+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2448) > back key grab
09-26 21:26:42.708+0900 W/AUL_AMD ( 2879): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.chattingapp) pkgid(org.example.chattingapp) attribute(600)
09-26 21:26:42.708+0900 D/RESOURCED( 2954): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.chattingapp, pkgid = org.example.chattingapp, flags = 1536
09-26 21:26:42.708+0900 D/RESOURCED( 2954): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.chattingapp, pkgname = org.example.chattingapp, ref = 1
09-26 21:26:42.708+0900 E/RESOURCED( 2954): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-26 21:26:42.708+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
09-26 21:26:42.708+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2648) > process_pool: false
09-26 21:26:42.718+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
09-26 21:26:42.718+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.chattingapp
09-26 21:26:42.718+0900 W/AUL_AMD ( 2879): amd_launch.c: _start_app(2665) > pad pid(-5)
09-26 21:26:42.718+0900 D/AUL_AMD ( 2879): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
09-26 21:26:42.718+0900 D/AUL_AMD ( 2879): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
09-26 21:26:42.718+0900 D/AUL     ( 2879): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.chattingapp
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
09-26 21:26:42.718+0900 W/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
09-26 21:26:42.718+0900 D/AUL     ( 3028): process_pool.c: __send_pkt_raw_data(219) > send(13) : 912 / 912
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5172, bin path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:26:42.718+0900 W/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(265) > Check app launching
09-26 21:26:42.718+0900 D/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 912, pkt->len: 904
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.chattingapp, launchpad type: 0
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.chattingapp
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.chattingapp
09-26 21:26:42.718+0900 D/AUL     ( 5172): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5173) is sent.
09-26 21:26:42.718+0900 D/AUL     ( 5172): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5173, signo: 10
09-26 21:26:42.718+0900 D/AUL     ( 5172): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.chattingapp / pkg_type : rpm / app_path : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.chattingapp/bin/chattingapp##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : PQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AGAAAAG9yZy5leGFtcGxlLmNoYXR0aW5nYXBwAA==##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzQ4OTI4MDIvNzAzMjIxAA==##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTg0AA==##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.chattingapp/bin/chattingapp, real app argc: 14
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
09-26 21:26:42.718+0900 D/AUL_PAD ( 5172): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.chattingapp/bin/chattingapp)
09-26 21:26:42.738+0900 I/CAPI_APPFW_APPLICATION( 5172): app_main.c: ui_app_main(788) > app_efl_main
09-26 21:26:42.738+0900 D/LAUNCH  ( 5172): appcore-efl.c: appcore_efl_main(1692) > [chattingapp:Application:main:done]
09-26 21:26:42.738+0900 D/APP_CORE( 5172): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
09-26 21:26:42.738+0900 D/APP_CORE( 5172): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.chattingapp/res/locale
09-26 21:26:42.738+0900 D/APP_CORE( 5172): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
09-26 21:26:42.748+0900 D/APP_CORE( 5172): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
09-26 21:26:42.748+0900 D/AUL     ( 5172): app_sock.c: __create_server_sock(156) > pg path - already exists
09-26 21:26:42.748+0900 D/APP_CORE( 5172): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb427c520
09-26 21:26:42.748+0900 D/LAUNCH  ( 5172): appcore-efl.c: __before_loop(1136) > [chattingapp:Platform:appcore_init:done]
09-26 21:26:42.748+0900 I/CAPI_APPFW_APPLICATION( 5172): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
09-26 21:26:42.788+0900 E/E17     ( 2793): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
09-26 21:26:42.798+0900 D/IMMODULE( 5172): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
09-26 21:26:42.798+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:26:42.798+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:26:42.798+0900 E/E17     ( 2793): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
09-26 21:26:42.798+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:26:42.798+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:26:42.808+0900 W/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5172
09-26 21:26:42.808+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 21:26:42.808+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 21:26:42.808+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:26:42.808+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:26:42.808+0900 D/ISF_QUERY( 5172): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
09-26 21:26:42.808+0900 D/ISF_QUERY( 5172): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:26:42.808+0900 D/ISF_QUERY( 5172): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:26:42.808+0900 D/ISF_QUERY( 5172): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:26:42.808+0900 D/ISF_QUERY( 5172): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:26:42.808+0900 D/ISF_QUERY( 5172): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:26:42.808+0900 D/ISF_QUERY( 5172): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:26:42.808+0900 D/INDICATOR( 2958): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
09-26 21:26:42.808+0900 D/INDICATOR( 2958): util.c: util_signal_emit_by_win(116) > emission bg.opaque
09-26 21:26:42.808+0900 D/INDICATOR( 2958): main.c: _rotate_window(229) > Indicator angle is 0 degree
09-26 21:26:42.808+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
09-26 21:26:42.808+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
09-26 21:26:42.808+0900 D/INDICATOR( 2958): main.c: _rotate_window(252) > port :: hide more icon
09-26 21:26:42.818+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:26:42.818+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:26:42.818+0900 D/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
09-26 21:26:42.818+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5172, appid: org.example.chattingapp
09-26 21:26:42.818+0900 D/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
09-26 21:26:42.818+0900 E/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(330) > access
09-26 21:26:42.818+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2700) > add app group info
09-26 21:26:42.818+0900 E/AUL     ( 2879): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
09-26 21:26:42.818+0900 D/AUL_AMD ( 2879): amd_status.c: _status_add_app_info_list(427) > pid(5172) appid(org.example.chattingapp) pkgid(org.example.chattingapp) comp(uiapp)
09-26 21:26:42.818+0900 D/AUL     ( 2984): launch.c: app_request_to_launchpad(425) > launch request result : 5172
09-26 21:26:42.818+0900 E/cluster-home( 2984): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.chattingapp]
09-26 21:26:42.818+0900 D/test-log( 2984): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
09-26 21:26:42.818+0900 D/IMMODULE( 5172): scim_panel_client.cpp: open_connection(162) > 
09-26 21:26:42.818+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 21:26:42.818+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 15
09-26 21:26:42.818+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:26:42.818+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:42.818+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:26:42.818+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 21:26:42.818+0900 D/ISF_SOCKET( 5172): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:26:42.818+0900 D/AUL_AMD ( 2879): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5172 is org.example.chattingapp
09-26 21:26:42.818+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5172 : 0
09-26 21:26:42.818+0900 D/AUL     ( 3056): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 32
09-26 21:26:42.818+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.chattingapp, 5172
09-26 21:26:42.818+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.chattingapp with pkgname
09-26 21:26:42.818+0900 E/RESOURCED( 2954): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.chattingapp
09-26 21:26:42.818+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(888) > available memory = 307
09-26 21:26:42.818+0900 D/IMMODULE( 5172): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
09-26 21:26:42.858+0900 D/LAUNCH  ( 5172): appcore-efl.c: __before_loop(1154) > [chattingapp:Application:create:done]
09-26 21:26:42.858+0900 D/APP_CORE( 5172): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
09-26 21:26:42.868+0900 D/APP_CORE( 5172): appcore.c: __aul_handler(587) > [APP 5172]     AUL event: AUL_START
09-26 21:26:42.868+0900 I/APP_CORE( 5172): appcore-efl.c: __do_app(496) > [APP 5172] Event: RESET State: CREATED
09-26 21:26:42.868+0900 D/APP_CORE( 5172): appcore-efl.c: __do_app(527) > [APP 5172] RESET
09-26 21:26:42.868+0900 D/LAUNCH  ( 5172): appcore-efl.c: __do_app(529) > [chattingapp:Application:reset:start]
09-26 21:26:42.868+0900 D/APP_CORE( 5172): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
09-26 21:26:42.868+0900 D/APP_CORE( 5172): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 21:26:42.868+0900 I/CAPI_APPFW_APPLICATION( 5172): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
09-26 21:26:42.868+0900 D/LAUNCH  ( 5172): appcore-efl.c: __do_app(544) > [chattingapp:Application:reset:done]
09-26 21:26:42.868+0900 D/APP_CORE( 5172): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
09-26 21:26:42.868+0900 E/EFL     ( 5172): edje<5172> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:26:42.868+0900 E/EFL     ( 5172): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:26:42.868+0900 E/EFL     ( 5172): edje<5172> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:26:42.868+0900 E/EFL     ( 5172): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:26:42.868+0900 E/EFL     ( 5172): edje<5172> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:26:42.868+0900 E/EFL     ( 5172): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:26:42.898+0900 W/APP_CORE( 5172): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
09-26 21:26:42.898+0900 D/APP_CORE( 5172): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
09-26 21:26:42.898+0900 D/APP_CORE( 5172): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
09-26 21:26:42.898+0900 D/AUL     ( 5172): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
09-26 21:26:42.898+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 34
09-26 21:26:42.928+0900 D/IMMODULE( 5172): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb7d43970. set autocapital type : 2
09-26 21:26:42.928+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 21:26:42.928+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 14340025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 21:26:42.928+0900 D/IMMODULE( 5172): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb7d43970. on demand : 0
09-26 21:26:42.928+0900 D/IMMODULE( 5172): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 21:26:42.928+0900 D/IMMODULE( 5172): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb7d43970, cursor pos : 0
09-26 21:26:43.018+0900 D/APP_CORE( 5172): appcore.c: __prt_ltime(236) > [APP 5172] first idle after reset: 318 msec
09-26 21:26:43.078+0900 E/E17     ( 2793): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
09-26 21:26:43.078+0900 D/APP_CORE( 5172): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
09-26 21:26:43.078+0900 D/APP_CORE( 5172): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
09-26 21:26:43.078+0900 D/APP_CORE( 5172): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
09-26 21:26:43.078+0900 I/APP_CORE( 5172): appcore-efl.c: __do_app(496) > [APP 5172] Event: RESUME State: CREATED
09-26 21:26:43.078+0900 D/LAUNCH  ( 5172): appcore-efl.c: __do_app(597) > [chattingapp:Application:resume:start]
09-26 21:26:43.078+0900 D/APP_CORE( 5172): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
09-26 21:26:43.078+0900 D/APP_CORE( 5172): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 21:26:43.078+0900 D/APP_CORE( 5172): appcore-efl.c: __do_app(607) > [APP 5172] RESUME
09-26 21:26:43.078+0900 D/APP_CORE( 2984): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
09-26 21:26:43.078+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
09-26 21:26:43.078+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
09-26 21:26:43.078+0900 I/APP_CORE( 2984): appcore-efl.c: __do_app(496) > [APP 2984] Event: PAUSE State: RUNNING
09-26 21:26:43.078+0900 D/APP_CORE( 2984): appcore-efl.c: __do_app(565) > [APP 2984] PAUSE
09-26 21:26:43.078+0900 I/CAPI_APPFW_APPLICATION( 2984): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
09-26 21:26:43.078+0900 E/cluster-home( 2984): homescreen.cpp: OnPause(84) >  app pause
09-26 21:26:43.078+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
09-26 21:26:43.078+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(923) >  END
09-26 21:26:43.078+0900 D/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 21:26:43.078+0900 E/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 21:26:43.078+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(2984) status(4)
09-26 21:26:43.078+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(2984) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
09-26 21:26:43.078+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
09-26 21:26:43.078+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2984, appid: org.tizen.homescreen, status: bg
09-26 21:26:43.078+0900 I/APP_CORE( 5172): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
09-26 21:26:43.078+0900 I/APP_CORE( 5172): appcore-efl.c: __do_app(614) > [APP 5172] Initial Launching, call the resume_cb
09-26 21:26:43.078+0900 I/CAPI_APPFW_APPLICATION( 5172): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
09-26 21:26:43.078+0900 D/LAUNCH  ( 5172): appcore-efl.c: __do_app(636) > [chattingapp:Application:resume:done]
09-26 21:26:43.078+0900 D/LAUNCH  ( 5172): appcore-efl.c: __do_app(638) > [chattingapp:Application:Launching:done]
09-26 21:26:43.078+0900 D/APP_CORE( 5172): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 21:26:43.078+0900 E/APP_CORE( 5172): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 21:26:43.078+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2891) > pid(5172) status(3)
09-26 21:26:43.078+0900 D/AUL_AMD ( 2879): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
09-26 21:26:43.088+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2897) > back key ungrab
09-26 21:26:43.088+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(5172) status(3)
09-26 21:26:43.088+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(5172) appid(org.example.chattingapp) pkgid(org.example.chattingapp) status(3)
09-26 21:26:43.088+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.chattingapp
09-26 21:26:43.088+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5172, appid: org.example.chattingapp, status: fg
09-26 21:26:43.088+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5172
09-26 21:26:43.088+0900 D/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5172, proc_name: org.example.chattingapp, cg_name: foreground, oom_score_adj: 200
09-26 21:26:43.088+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5172
09-26 21:26:43.088+0900 D/DATA_PROVIDER_MASTER( 3030): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2984 is paused
09-26 21:26:43.088+0900 D/DATA_PROVIDER_MASTER( 3030): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
09-26 21:26:43.158+0900 D/RESOURCED( 2954): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5172, appname = org.example.chattingapp, pkgname = org.example.chattingapp
09-26 21:26:43.158+0900 D/RESOURCED( 2954): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5172, appname = org.example.chattingapp
09-26 21:26:43.158+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5172
09-26 21:26:43.158+0900 I/RESOURCED( 2954): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
09-26 21:26:43.158+0900 I/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
09-26 21:26:43.288+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2910) > pid(5172) status(0)
09-26 21:26:43.818+0900 D/AUL_PAD ( 3028): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
09-26 21:26:43.818+0900 D/AUL_PAD ( 3028): sigchild.h: __send_app_launch_signal(131) > send launch signal done
09-26 21:26:43.828+0900 E/RESOURCED( 2954): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.317
09-26 21:26:43.828+0900 D/AUL_PAD ( 5219): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
09-26 21:26:43.838+0900 D/IMMODULE( 5172): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb7d43970
09-26 21:26:43.838+0900 D/IMMODULE( 5172): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 21:26:43.838+0900 D/IMMODULE( 5172): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb7d43970
09-26 21:26:43.838+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x201f3c 
09-26 21:26:43.838+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 21:26:43.898+0900 D/IMMODULE( 5172): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
09-26 21:26:43.898+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
09-26 21:26:43.898+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
09-26 21:26:43.898+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
09-26 21:26:43.898+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 21:26:43.898+0900 D/SCIM_HELPER( 3149): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 21:26:43.898+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
09-26 21:26:43.938+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
09-26 21:26:43.938+0900 D/ISE_DEFAULT( 3149): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
09-26 21:26:44.058+0900 W/CRASH_MANAGER( 4851): worker.c: worker_job(1204) > 1105172636861147489280
