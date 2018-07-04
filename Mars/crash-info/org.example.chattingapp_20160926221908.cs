S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: chattingapp
PID: 7731
Date: 2016-09-26 22:19:08+0900
Executable File Path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb91c19d0, esi = 0xbfbc4240
ebp = 0xbfbc4288, esp = 0xbfbc423c
eax = 0xb34d66b8, ebx = 0xb34d82cc
ecx = 0x00000076, edx = 0x00000000
eip = 0xb6d10c0b

Memory Information
MemTotal:      123 KB
MemFree:        20 KB
Buffers:         4 KB
Cached:     202640 KB
VmPeak:     116680 KB
VmSize:     116680 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23684 KB
VmRSS:       23684 KB
VmData:      52132 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33536 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 7731 TID = 7731
7731 7741 7754 7758 7759 7783 

Maps Information
b1ae5000 b1afd000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2c04000 b2c0b000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2c17000 b2c1e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2c1f000 b2c29000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c2f000 b2c3b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c3c000 b2c5d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c62000 b2c63000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c64000 b2c69000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c6a000 b2c6b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c6c000 b2c6e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c6f000 b2c71000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c72000 b2c7e000 r-xp /usr/lib/libdrm.so.2.4.0
b2c7f000 b2c82000 r-xp /usr/lib/libdri2.so.0.0.0
b2c83000 b2c8d000 r-xp /usr/lib/libtbm.so.1.0.0
b2c8e000 b2c8f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2c90000 b2ca5000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2ca6000 b2cb8000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34ba000 b34c3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34c4000 b34d8000 r-xp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
b35e0000 b35e6000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e7000 b372b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3741000 b3742000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3743000 b3744000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3745000 b3748000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3749000 b374c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b374d000 b3786000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4189000 b4194000 r-xp /lib/libnss_files-2.20-2014.11.so
b4196000 b41a1000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41a3000 b41ba000 r-xp /lib/libnsl-2.20-2014.11.so
b41be000 b41c6000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41c8000 b41ec000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41ed000 b41ee000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41ef000 b41f2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41f3000 b41fa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41fb000 b4205000 r-xp /usr/lib/libsensord-share.so
b4206000 b4222000 r-xp /usr/lib/libsensor.so.1.2.0
b4224000 b422d000 r-xp /usr/lib/libappcore-common.so.1.1
b4230000 b4232000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4247000 b4249000 r-xp /usr/lib/libXau.so.6.0.0
b424a000 b426c000 r-xp /usr/lib/libxcb.so.1.1.0
b426e000 b4277000 r-xp /lib/libcrypt-2.20-2014.11.so
b42a0000 b42a2000 r-xp /usr/lib/libiri.so
b42a3000 b42c9000 r-xp /lib/libexpat.so.1.5.2
b42cb000 b4336000 r-xp /usr/lib/libssl.so.1.0.0
b433c000 b4348000 r-xp /usr/lib/libethumb.so.1.13.0
b4349000 b434d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b434e000 b459f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b1a000 b5b2a000 r-xp /usr/lib/libXi.so.6.1.0
b5b2b000 b5b2d000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b2e000 b5b34000 r-xp /usr/lib/libXtst.so.6.1.0
b5b35000 b5b3f000 r-xp /usr/lib/libXrender.so.1.3.0
b5b40000 b5b49000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b4b000 b5b4d000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b4e000 b5b53000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b54000 b5b66000 r-xp /usr/lib/libXext.so.6.4.0
b5b67000 b5b69000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b6a000 b5b6c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b6e000 b5cb0000 r-xp /usr/lib/libX11.so.6.3.0
b5cb4000 b5cbe000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cbf000 b5cd5000 r-xp /usr/lib/libudev.so.1.6.0
b5cd8000 b5cdc000 r-xp /lib/libattr.so.1.1.0
b5cdd000 b5d0c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d0e000 b5d14000 r-xp /usr/lib/libffi.so.6.0.2
b5d15000 b5d38000 r-xp /lib/libz.so.1.2.8
b5d39000 b5d3c000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d3d000 b5e99000 r-xp /usr/lib/libxml2.so.2.9.2
b5e9f000 b5f86000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f93000 b5f96000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f97000 b5fb9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fba000 b5fce000 r-xp /lib/libresolv-2.20-2014.11.so
b5fd2000 b5ff6000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff7000 b5ff9000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ffb000 b6005000 r-xp /usr/lib/libembryo.so.1.13.0
b6006000 b602f000 r-xp /usr/lib/libpng12.so.0.50.0
b6030000 b6079000 r-xp /usr/lib/libjpeg.so.8.0.2
b608a000 b6091000 r-xp /lib/librt-2.20-2014.11.so
b6093000 b60b2000 r-xp /usr/lib/libector.so.1.13.0
b60b5000 b60e2000 r-xp /usr/lib/liblua-5.1.so
b60e3000 b6173000 r-xp /usr/lib/libfreetype.so.6.11.3
b6177000 b61b5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61b6000 b61cc000 r-xp /usr/lib/libfribidi.so.0.3.1
b61cd000 b6226000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6229000 b6274000 r-xp /lib/libm-2.20-2014.11.so
b6276000 b6288000 r-xp /usr/lib/libeio.so.1.13.0
b6289000 b628c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b628d000 b6293000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6294000 b62b7000 r-xp /usr/lib/libefreet.so.1.13.0
b62ba000 b62e5000 r-xp /usr/lib/libeldbus.so.1.13.0
b62e6000 b631a000 r-xp /usr/lib/libecore_con.so.1.13.0
b631c000 b6325000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6326000 b632f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6330000 b6343000 r-xp /usr/lib/libeo.so.1.13.0
b6345000 b6358000 r-xp /usr/lib/libecore_input.so.1.13.0
b6359000 b6360000 r-xp /usr/lib/libecore_file.so.1.13.0
b6361000 b6384000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6385000 b63b1000 r-xp /usr/lib/libeet.so.1.13.0
b63ba000 b6425000 r-xp /usr/lib/libeina.so.1.13.0
b6428000 b643f000 r-xp /usr/lib/libefl.so.1.13.0
b6441000 b65a8000 r-xp /usr/lib/libicuuc.so.51.1
b65b6000 b67c2000 r-xp /usr/lib/libicui18n.so.51.1
b67ca000 b6819000 r-xp /usr/lib/libecore_x.so.1.13.0
b681b000 b6835000 r-xp /lib/libgcc_s-4.9.so.1
b6837000 b683b000 r-xp /lib/libcap.so.2.21
b683c000 b6882000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6883000 b688a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b688c000 b68de000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68e0000 b6a6b000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a70000 b6b3e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b41000 b6b45000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b46000 b6b55000 r-xp /usr/lib/libvconf.so.0.2.45
b6b56000 b6b59000 r-xp /usr/lib/libvasum.so.0.3.1
b6b5a000 b6b5d000 r-xp /usr/lib/libttrace.so.1.1
b6b5f000 b6b63000 r-xp /usr/lib/libiniparser.so.0
b6b64000 b6b94000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b95000 b6b9e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b9f000 b6bc4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc5000 b6bd5000 r-xp /usr/lib/libunwind.so.8.0.1
b6bdf000 b6d8d000 r-xp /lib/libc-2.20-2014.11.so
b6d95000 b6ed8000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6eda000 b6f32000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f33000 b6f67000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f6a000 b703e000 r-xp /usr/lib/libedje.so.1.13.0
b7041000 b706d000 r-xp /usr/lib/libecore.so.1.13.0
b707e000 b72a4000 r-xp /usr/lib/libevas.so.1.13.0
b72cc000 b72e4000 r-xp /lib/libpthread-2.20-2014.11.so
b72e8000 b7662000 r-xp /usr/lib/libelementary.so.1.13.0
b7682000 b7686000 r-xp /usr/lib/libsmack.so.1.0.0
b7687000 b7690000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7691000 b7694000 r-xp /usr/lib/libdlog.so.0.0.0
b7695000 b769a000 r-xp /usr/lib/libbundle.so.0.1.22
b769b000 b769e000 r-xp /lib/libdl-2.20-2014.11.so
b76a0000 b76c5000 r-xp /usr/lib/libaul.so.0.1.0
b76c8000 b76ca000 r-xp /usr/lib/libappsvc.so.0.1.0
b76cb000 b76d0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76d1000 b76d8000 r-xp /usr/lib/libappcore-efl.so.1.1
b76da000 b76df000 r-xp /usr/lib/libsys-assert.so
b76e2000 b76e3000 r-xp [vdso]
b76e3000 b7705000 r-xp /lib/ld-2.20-2014.11.so
b7707000 b770f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7731)
Call Stack Count: 49
 0: (0xb6d10c0b) [/lib/libc.so.6] + 0x131c0b
 1: pop_from_stack_uib_vc + 0x6b (0xb34d178b) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xd78b
 2: uib_views_destroy_callback + 0x5c (0xb34d170c) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xd70c
 3: (0xb70b2449) [/usr/lib/libevas.so.1] + 0x34449
 4: (0xb633e319) [/usr/lib/libeo.so.1] + 0xe319
 5: eo_event_callback_call + 0xb3 (0xb633bd63) [/usr/lib/libeo.so.1] + 0xbd63
 6: (0xb70b2a62) [/usr/lib/libevas.so.1] + 0x34a62
 7: (0xb70fd32a) [/usr/lib/libevas.so.1] + 0x7f32a
 8: eo_destructor + 0x99 (0xb633b079) [/usr/lib/libeo.so.1] + 0xb079
 9: (0xb755938b) [/usr/lib/libelementary.so.1] + 0x27138b
10: eo_destructor + 0x99 (0xb633b079) [/usr/lib/libeo.so.1] + 0xb079
11: _eo_do_end + 0x15b (0xb63335ab) [/usr/lib/libeo.so.1] + 0x35ab
12: eo_del + 0xb3 (0xb63387a3) [/usr/lib/libeo.so.1] + 0x87a3
13: evas_object_del + 0x81 (0xb70f2cc1) [/usr/lib/libevas.so.1] + 0x74cc1
14: (0xb7567245) [/usr/lib/libelementary.so.1] + 0x27f245
15: evas_obj_smart_del + 0x99 (0xb7108eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
16: (0xb749c706) [/usr/lib/libelementary.so.1] + 0x1b4706
17: evas_obj_smart_del + 0x99 (0xb7108eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
18: (0xb710a6f1) [/usr/lib/libevas.so.1] + 0x8c6f1
19: (0xb70fd75b) [/usr/lib/libevas.so.1] + 0x7f75b
20: eo_destructor + 0x99 (0xb633b079) [/usr/lib/libeo.so.1] + 0xb079
21: (0xb755938b) [/usr/lib/libelementary.so.1] + 0x27138b
22: eo_destructor + 0x99 (0xb633b079) [/usr/lib/libeo.so.1] + 0xb079
23: _eo_do_end + 0x15b (0xb63335ab) [/usr/lib/libeo.so.1] + 0x35ab
24: eo_del + 0xb3 (0xb63387a3) [/usr/lib/libeo.so.1] + 0x87a3
25: evas_object_del + 0x81 (0xb70f2cc1) [/usr/lib/libevas.so.1] + 0x74cc1
26: (0xb75569d1) [/usr/lib/libelementary.so.1] + 0x26e9d1
27: eo_destructor + 0x99 (0xb633b079) [/usr/lib/libeo.so.1] + 0xb079
28: (0xb73886af) [/usr/lib/libelementary.so.1] + 0xa06af
29: eo_destructor + 0x99 (0xb633b079) [/usr/lib/libeo.so.1] + 0xb079
30: _eo_do_end + 0x15b (0xb63335ab) [/usr/lib/libeo.so.1] + 0x35ab
31: (0xb7387646) [/usr/lib/libelementary.so.1] + 0x9f646
32: (0xb7492626) [/usr/lib/libelementary.so.1] + 0x1aa626
33: (0xb6fedf39) [/usr/lib/libedje.so.1] + 0x83f39
34: (0xb6ff4a11) [/usr/lib/libedje.so.1] + 0x8aa11
35: (0xb6feefdc) [/usr/lib/libedje.so.1] + 0x84fdc
36: (0xb6fef4cb) [/usr/lib/libedje.so.1] + 0x854cb
37: (0xb6fef68f) [/usr/lib/libedje.so.1] + 0x8568f
38: (0xb7054702) [/usr/lib/libecore.so.1] + 0x13702
39: (0xb704e055) [/usr/lib/libecore.so.1] + 0xd055
40: (0xb70571b9) [/usr/lib/libecore.so.1] + 0x161b9
41: ecore_main_loop_begin + 0x57 (0xb7057587) [/usr/lib/libecore.so.1] + 0x16587
42: elm_run + 0x2d (0xb74b022d) [/usr/lib/libelementary.so.1] + 0x1c822d
43: appcore_efl_main + 0x4de (0xb76d4dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
44: ui_app_main + 0x140 (0xb76cdc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
45: app_run + 0x1cb (0xb34d452b) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x1052b
46: main + 0x258 (0xb34d6478) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x12478
47: (0xb7709148) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xb7709148
48: __libc_start_main + 0xde (0xb6bf6e4e) [/lib/libc.so.6] + 0x17e4e
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
LAUNCH  ( 7731): appcore-efl.c: appcore_efl_main(1692) > [chattingapp:Application:main:done]
09-26 22:18:56.629+0900 D/APP_CORE( 7731): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
09-26 22:18:56.629+0900 D/APP_CORE( 7731): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.chattingapp/res/locale
09-26 22:18:56.629+0900 D/APP_CORE( 7731): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
09-26 22:18:56.639+0900 D/APP_CORE( 7731): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
09-26 22:18:56.639+0900 D/AUL     ( 7731): app_sock.c: __create_server_sock(156) > pg path - already exists
09-26 22:18:56.639+0900 D/APP_CORE( 7731): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb422d520
09-26 22:18:56.639+0900 D/LAUNCH  ( 7731): appcore-efl.c: __before_loop(1136) > [chattingapp:Platform:appcore_init:done]
09-26 22:18:56.639+0900 I/CAPI_APPFW_APPLICATION( 7731): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
09-26 22:18:56.709+0900 E/E17     ( 2793): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
09-26 22:18:56.709+0900 D/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
09-26 22:18:56.709+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7731, appid: org.example.chattingapp
09-26 22:18:56.709+0900 D/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
09-26 22:18:56.709+0900 E/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(330) > access
09-26 22:18:56.709+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2700) > add app group info
09-26 22:18:56.709+0900 E/AUL     ( 2879): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
09-26 22:18:56.709+0900 D/AUL_AMD ( 2879): amd_status.c: _status_add_app_info_list(427) > pid(7731) appid(org.example.chattingapp) pkgid(org.example.chattingapp) comp(uiapp)
09-26 22:18:56.709+0900 D/AUL     ( 2984): launch.c: app_request_to_launchpad(425) > launch request result : 7731
09-26 22:18:56.709+0900 E/cluster-home( 2984): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.chattingapp]
09-26 22:18:56.709+0900 D/test-log( 2984): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
09-26 22:18:56.709+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.chattingapp, 7731
09-26 22:18:56.709+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.chattingapp with pkgname
09-26 22:18:56.709+0900 E/RESOURCED( 2954): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.chattingapp
09-26 22:18:56.719+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(888) > available memory = 303
09-26 22:18:56.719+0900 D/IMMODULE( 7731): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
09-26 22:18:56.719+0900 E/E17     ( 2793): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
09-26 22:18:56.719+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 22:18:56.719+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(524) > connect() succeeded
09-26 22:18:56.719+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 22:18:56.719+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(524) > connect() succeeded
09-26 22:18:56.739+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 22:18:56.739+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(524) > connect() succeeded
09-26 22:18:56.739+0900 D/ISF_QUERY( 7731): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
09-26 22:18:56.739+0900 D/ISF_QUERY( 7731): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 22:18:56.739+0900 D/ISF_QUERY( 7731): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 22:18:56.739+0900 D/ISF_QUERY( 7731): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 22:18:56.739+0900 D/ISF_QUERY( 7731): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 22:18:56.739+0900 D/ISF_QUERY( 7731): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 22:18:56.739+0900 D/ISF_QUERY( 7731): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 22:18:56.749+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 22:18:56.749+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(524) > connect() succeeded
09-26 22:18:56.749+0900 W/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7731
09-26 22:18:56.749+0900 D/IMMODULE( 7731): scim_panel_client.cpp: open_connection(162) > 
09-26 22:18:56.749+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 22:18:56.749+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(524) > connect() succeeded
09-26 22:18:56.749+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 22:18:56.749+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 22:18:56.749+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 22:18:56.749+0900 D/ISF_SOCKET( 7731): scim_socket.cpp: connect(524) > connect() succeeded
09-26 22:18:56.749+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 15
09-26 22:18:56.749+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 22:18:56.749+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 22:18:56.749+0900 D/INDICATOR( 2958): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
09-26 22:18:56.759+0900 D/INDICATOR( 2958): util.c: util_signal_emit_by_win(116) > emission bg.opaque
09-26 22:18:56.759+0900 D/INDICATOR( 2958): main.c: _rotate_window(229) > Indicator angle is 0 degree
09-26 22:18:56.759+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
09-26 22:18:56.759+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
09-26 22:18:56.759+0900 D/INDICATOR( 2958): main.c: _rotate_window(252) > port :: hide more icon
09-26 22:18:56.759+0900 D/AUL_AMD ( 2879): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7731 is org.example.chattingapp
09-26 22:18:56.759+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7731 : 0
09-26 22:18:56.759+0900 D/AUL     ( 3056): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 32
09-26 22:18:56.769+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
09-26 22:18:56.839+0900 D/LAUNCH  ( 7731): appcore-efl.c: __before_loop(1154) > [chattingapp:Application:create:done]
09-26 22:18:56.839+0900 D/APP_CORE( 7731): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
09-26 22:18:56.899+0900 D/APP_CORE( 7731): appcore.c: __aul_handler(587) > [APP 7731]     AUL event: AUL_START
09-26 22:18:56.899+0900 I/APP_CORE( 7731): appcore-efl.c: __do_app(496) > [APP 7731] Event: RESET State: CREATED
09-26 22:18:56.899+0900 D/APP_CORE( 7731): appcore-efl.c: __do_app(527) > [APP 7731] RESET
09-26 22:18:56.899+0900 D/LAUNCH  ( 7731): appcore-efl.c: __do_app(529) > [chattingapp:Application:reset:start]
09-26 22:18:56.899+0900 D/APP_CORE( 7731): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
09-26 22:18:56.899+0900 D/APP_CORE( 7731): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 22:18:56.899+0900 I/CAPI_APPFW_APPLICATION( 7731): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
09-26 22:18:56.899+0900 D/LAUNCH  ( 7731): appcore-efl.c: __do_app(544) > [chattingapp:Application:reset:done]
09-26 22:18:56.899+0900 D/APP_CORE( 7731): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
09-26 22:18:56.899+0900 E/EFL     ( 7731): edje<7731> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 22:18:56.899+0900 E/EFL     ( 7731): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 22:18:56.909+0900 E/EFL     ( 7731): edje<7731> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 22:18:56.909+0900 E/EFL     ( 7731): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 22:18:56.909+0900 E/EFL     ( 7731): edje<7731> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 22:18:56.909+0900 E/EFL     ( 7731): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 22:18:56.959+0900 W/APP_CORE( 7731): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
09-26 22:18:56.959+0900 D/APP_CORE( 7731): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
09-26 22:18:56.959+0900 D/APP_CORE( 7731): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
09-26 22:18:56.959+0900 D/AUL     ( 7731): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
09-26 22:18:56.959+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 34
09-26 22:18:56.979+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9109e90. set autocapital type : 2
09-26 22:18:56.979+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9109e90. on demand : 0
09-26 22:18:56.979+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 22:18:56.979+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 1e330025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 22:18:56.979+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 22:18:56.979+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9109e90, cursor pos : 0
09-26 22:18:57.079+0900 D/APP_CORE( 7731): appcore.c: __prt_ltime(236) > [APP 7731] first idle after reset: 493 msec
09-26 22:18:57.129+0900 E/E17     ( 2793): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
09-26 22:18:57.129+0900 D/APP_CORE( 7731): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
09-26 22:18:57.129+0900 D/APP_CORE( 7731): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
09-26 22:18:57.129+0900 D/APP_CORE( 7731): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
09-26 22:18:57.129+0900 I/APP_CORE( 7731): appcore-efl.c: __do_app(496) > [APP 7731] Event: RESUME State: CREATED
09-26 22:18:57.129+0900 D/LAUNCH  ( 7731): appcore-efl.c: __do_app(597) > [chattingapp:Application:resume:start]
09-26 22:18:57.129+0900 D/APP_CORE( 7731): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
09-26 22:18:57.129+0900 D/APP_CORE( 7731): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 22:18:57.129+0900 D/APP_CORE( 7731): appcore-efl.c: __do_app(607) > [APP 7731] RESUME
09-26 22:18:57.129+0900 I/APP_CORE( 7731): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
09-26 22:18:57.129+0900 I/APP_CORE( 7731): appcore-efl.c: __do_app(614) > [APP 7731] Initial Launching, call the resume_cb
09-26 22:18:57.129+0900 I/CAPI_APPFW_APPLICATION( 7731): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
09-26 22:18:57.129+0900 D/LAUNCH  ( 7731): appcore-efl.c: __do_app(636) > [chattingapp:Application:resume:done]
09-26 22:18:57.129+0900 D/LAUNCH  ( 7731): appcore-efl.c: __do_app(638) > [chattingapp:Application:Launching:done]
09-26 22:18:57.129+0900 D/APP_CORE( 7731): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 22:18:57.129+0900 E/APP_CORE( 7731): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 22:18:57.129+0900 D/APP_CORE( 2984): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
09-26 22:18:57.129+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
09-26 22:18:57.129+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
09-26 22:18:57.129+0900 I/APP_CORE( 2984): appcore-efl.c: __do_app(496) > [APP 2984] Event: PAUSE State: RUNNING
09-26 22:18:57.129+0900 D/APP_CORE( 2984): appcore-efl.c: __do_app(565) > [APP 2984] PAUSE
09-26 22:18:57.129+0900 I/CAPI_APPFW_APPLICATION( 2984): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
09-26 22:18:57.129+0900 E/cluster-home( 2984): homescreen.cpp: OnPause(84) >  app pause
09-26 22:18:57.129+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
09-26 22:18:57.129+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(923) >  END
09-26 22:18:57.129+0900 D/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 22:18:57.129+0900 E/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 22:18:57.129+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(2984) status(4)
09-26 22:18:57.129+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(2984) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
09-26 22:18:57.129+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
09-26 22:18:57.129+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2984, appid: org.tizen.homescreen, status: bg
09-26 22:18:57.129+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2891) > pid(7731) status(3)
09-26 22:18:57.129+0900 D/AUL_AMD ( 2879): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
09-26 22:18:57.139+0900 D/DATA_PROVIDER_MASTER( 3030): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2984 is paused
09-26 22:18:57.139+0900 D/DATA_PROVIDER_MASTER( 3030): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
09-26 22:18:57.149+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2897) > back key ungrab
09-26 22:18:57.149+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(7731) status(3)
09-26 22:18:57.149+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(7731) appid(org.example.chattingapp) pkgid(org.example.chattingapp) status(3)
09-26 22:18:57.149+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.chattingapp
09-26 22:18:57.149+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7731, appid: org.example.chattingapp, status: fg
09-26 22:18:57.149+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7731
09-26 22:18:57.149+0900 D/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7731, proc_name: org.example.chattingapp, cg_name: foreground, oom_score_adj: 200
09-26 22:18:57.149+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7731
09-26 22:18:57.219+0900 D/RESOURCED( 2954): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7731, appname = org.example.chattingapp, pkgname = org.example.chattingapp
09-26 22:18:57.219+0900 D/RESOURCED( 2954): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7731, appname = org.example.chattingapp
09-26 22:18:57.219+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7731
09-26 22:18:57.219+0900 I/RESOURCED( 2954): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
09-26 22:18:57.219+0900 I/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
09-26 22:18:57.219+0900 E/RESOURCED( 2954): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
09-26 22:18:57.299+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2910) > pid(7731) status(0)
09-26 22:18:57.709+0900 D/AUL_PAD ( 3028): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
09-26 22:18:57.709+0900 D/AUL_PAD ( 7776): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
09-26 22:18:57.719+0900 D/AUL_PAD ( 3028): sigchild.h: __send_app_launch_signal(131) > send launch signal done
09-26 22:18:57.729+0900 E/RESOURCED( 2954): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.560
09-26 22:18:58.049+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203a62 
09-26 22:18:58.059+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9109e90
09-26 22:18:58.059+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 22:18:58.059+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9109e90
09-26 22:18:58.069+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 22:18:58.219+0900 D/AUL_AMD ( 2879): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.chattingapp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 22:18:58.219+0900 D/RUA     ( 2879): rua.c: rua_add_history(179) > rua_add_history start
09-26 22:18:58.239+0900 D/RUA     ( 2879): rua.c: rua_add_history(247) > rua_add_history ok
09-26 22:18:58.299+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
09-26 22:18:58.299+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
09-26 22:18:58.299+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
09-26 22:18:58.299+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
09-26 22:18:58.299+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:18:58.299+0900 D/SCIM_HELPER( 3149): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:18:58.299+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:18:58.499+0900 E/CAPI_NETWORK_WIFI( 2958): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
09-26 22:18:58.499+0900 E/INDICATOR( 2958): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
09-26 22:18:58.499+0900 E/INDICATOR( 2958): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
09-26 22:18:58.499+0900 E/INDICATOR( 2958): 
09-26 22:18:58.599+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:18:58.599+0900 D/ISE_DEFAULT( 3149): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
09-26 22:18:58.749+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb91e0620. set autocapital type : 2
09-26 22:18:58.749+0900 D/AUL_PAD ( 7776): launchpad_loader.c: main(588) > sleeping 1 sec...
09-26 22:18:58.749+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(52) > max_cmdline_size = 1053
09-26 22:18:58.749+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 22:18:58.749+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 1e350025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 22:18:58.749+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb91e0620. on demand : 0
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7e5f760
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(69) > get pre-initialization function
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(73) > get shutdown function
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7e5fa40
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7e61640
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(69) > get pre-initialization function
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preload.h: __preload_init(73) > get shutdown function
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): preexec.h: __preexec_init(76) > preexec start
09-26 22:18:58.759+0900 D/AUL_PAD ( 7776): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
09-26 22:18:58.759+0900 D/AUL     ( 7776): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
09-26 22:18:58.759+0900 D/AUL     ( 7776): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
09-26 22:18:58.759+0900 D/AUL_PAD ( 3028): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
09-26 22:18:58.769+0900 D/AUL     ( 7776): process_pool.c: __connect_to_launchpad(132) > send(7776) : 4
09-26 22:18:58.769+0900 D/AUL     ( 7776): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
09-26 22:18:58.769+0900 D/AUL_PAD ( 3028): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 7776
09-26 22:18:58.769+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 22:18:58.769+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb91e0620, cursor pos : 0
09-26 22:18:58.859+0900 D/AUL_PAD ( 7776): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
09-26 22:18:58.869+0900 D/AUL_PAD ( 7776): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
09-26 22:18:58.869+0900 D/AUL_PAD ( 7776): launchpad_loader.c: main(693) > [candidate] ecore handler add
09-26 22:18:58.869+0900 D/AUL_PAD ( 7776): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
09-26 22:18:59.059+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
09-26 22:18:59.469+0900 E/EFL     ( 7746): eldbus<7746> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-d2fx8QdkxN: Connection refused
09-26 22:18:59.469+0900 E/EFL     ( 7746): <7746> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
09-26 22:18:59.469+0900 E/EFL     ( 7746): elementary<7746> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
09-26 22:18:59.469+0900 D/APP_CORE( 7746): appcore.c: __aul_handler(587) > [APP 7746]     AUL event: AUL_START
09-26 22:18:59.469+0900 I/APP_CORE( 7746): appcore-efl.c: __do_app(496) > [APP 7746] Event: RESET State: CREATED
09-26 22:18:59.469+0900 D/APP_CORE( 7746): appcore-efl.c: __do_app(527) > [APP 7746] RESET
09-26 22:18:59.469+0900 D/LAUNCH  ( 7746): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
09-26 22:18:59.469+0900 D/APP_CORE( 7746): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
09-26 22:18:59.469+0900 D/APP_CORE( 7746): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 22:18:59.469+0900 E/SYSPOPUP( 7746): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
09-26 22:18:59.469+0900 E/SYSPOPUP( 7746): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
09-26 22:18:59.469+0900 E/SYSPOPUP( 7746): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
09-26 22:18:59.469+0900 D/LAUNCH  ( 7746): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
09-26 22:18:59.469+0900 D/APP_CORE( 7746): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
09-26 22:18:59.499+0900 D/AUL     ( 7746): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
09-26 22:18:59.509+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 22
09-26 22:18:59.509+0900 W/AUL_AMD ( 2879): amd_request.c: __request_handler(1056) > app status : 5
09-26 22:18:59.509+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(7746) status(5)
09-26 22:18:59.509+0900 D/APP_CORE( 7746): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
09-26 22:18:59.509+0900 E/EFL     ( 7746): eo<7746> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
09-26 22:18:59.509+0900 E/EFL     ( 7746): eo<7746> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
09-26 22:18:59.729+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_down_cb(582) > XF86Back key is pressed.
09-26 22:18:59.729+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:18:59.729+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:18:59.789+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_up_cb(629) > XF86Back key is released.
09-26 22:18:59.789+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:18:59.789+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:18:59.789+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb91e0620
09-26 22:18:59.789+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 22:18:59.789+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb91e0620
09-26 22:18:59.799+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 22:18:59.849+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
09-26 22:18:59.849+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
09-26 22:18:59.849+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
09-26 22:18:59.849+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
09-26 22:18:59.849+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:18:59.849+0900 D/SCIM_HELPER( 3149): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:18:59.849+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:18:59.939+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:18:59.939+0900 D/ISE_DEFAULT( 3149): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
09-26 22:19:00.039+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb91e0620
09-26 22:19:00.039+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:00.039+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:00.699+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203a62 
09-26 22:19:00.869+0900 D/INDICATOR( 2958): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
09-26 22:19:00.869+0900 D/INDICATOR( 2958): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
09-26 22:19:00.869+0900 D/INDICATOR( 2958): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
09-26 22:19:00.869+0900 D/INDICATOR( 2958): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 10:19 5 h"
09-26 22:19:00.869+0900 D/INDICATOR( 2958): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 10:19"
09-26 22:19:00.869+0900 D/INDICATOR( 2958): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 10&#x2236;19"
09-26 22:19:00.869+0900 D/INDICATOR( 2958): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146509967 Time: <font_size=33>10&#x2236;19</font_size> <font_size=32>PM</font_size></font>
09-26 22:19:01.009+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb91d67d0. set autocapital type : 2
09-26 22:19:01.009+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 22:19:01.009+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 1e370025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 22:19:01.009+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb91d67d0. on demand : 0
09-26 22:19:01.029+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 22:19:01.029+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb91d67d0, cursor pos : 0
09-26 22:19:01.589+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_down_cb(582) > XF86Back key is pressed.
09-26 22:19:01.589+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:01.589+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:01.679+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_up_cb(629) > XF86Back key is released.
09-26 22:19:01.679+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:01.679+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:01.679+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb91d67d0
09-26 22:19:01.689+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 22:19:01.689+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb91d67d0
09-26 22:19:01.689+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 22:19:01.739+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
09-26 22:19:01.739+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
09-26 22:19:01.739+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
09-26 22:19:01.739+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
09-26 22:19:01.739+0900 D/SCIM_HELPER( 3149): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:01.739+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:01.739+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:01.869+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:01.869+0900 D/ISE_DEFAULT( 3149): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
09-26 22:19:01.969+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb91d67d0
09-26 22:19:01.969+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:01.969+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:02.129+0900 D/APP_CORE( 2984): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
09-26 22:19:02.129+0900 I/APP_CORE( 2984): appcore-efl.c: __do_app(496) > [APP 2984] Event: MEM_FLUSH State: PAUSED
09-26 22:19:02.129+0900 D/APP_CORE( 2984): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
09-26 22:19:02.129+0900 D/APP_CORE( 2984): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2984
09-26 22:19:02.129+0900 D/APP_CORE( 2984): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
09-26 22:19:02.129+0900 D/RESOURCED( 2954): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2984
09-26 22:19:02.329+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203a62 
09-26 22:19:02.609+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb9161740. set autocapital type : 2
09-26 22:19:02.609+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb9161740. on demand : 0
09-26 22:19:02.609+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 22:19:02.609+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 1e390025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 22:19:02.609+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 22:19:02.609+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb9161740, cursor pos : 0
09-26 22:19:02.939+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_down_cb(582) > XF86Back key is pressed.
09-26 22:19:02.939+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:02.939+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:03.029+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_up_cb(629) > XF86Back key is released.
09-26 22:19:03.029+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:03.029+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:03.029+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb9161740
09-26 22:19:03.029+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 22:19:03.029+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb9161740
09-26 22:19:03.039+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 22:19:03.079+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
09-26 22:19:03.089+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
09-26 22:19:03.089+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
09-26 22:19:03.089+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
09-26 22:19:03.089+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:03.089+0900 D/SCIM_HELPER( 3149): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:03.089+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:03.159+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:03.159+0900 D/ISE_DEFAULT( 3149): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
09-26 22:19:03.279+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb9161740
09-26 22:19:03.279+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:03.279+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:03.739+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203a62 
09-26 22:19:04.069+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb91e8080. set autocapital type : 2
09-26 22:19:04.079+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 22:19:04.079+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 1e3d0025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 22:19:04.079+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb91e8080. on demand : 0
09-26 22:19:04.089+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x203a62 bd->visible=1
09-26 22:19:04.089+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 22:19:04.089+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb91e8080, cursor pos : 0
09-26 22:19:04.289+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_down_cb(582) > XF86Back key is pressed.
09-26 22:19:04.289+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:04.289+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:04.379+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_up_cb(629) > XF86Back key is released.
09-26 22:19:04.379+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:04.379+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:04.379+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb91e8080
09-26 22:19:04.379+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 22:19:04.379+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb91e8080
09-26 22:19:04.379+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 22:19:04.429+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
09-26 22:19:04.429+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
09-26 22:19:04.429+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
09-26 22:19:04.429+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
09-26 22:19:04.429+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:04.429+0900 D/SCIM_HELPER( 3149): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:04.429+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:04.529+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:04.529+0900 D/ISE_DEFAULT( 3149): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
09-26 22:19:04.649+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb91e8080
09-26 22:19:04.649+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:04.649+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:05.379+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203a62 
09-26 22:19:06.469+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203a62 
09-26 22:19:06.929+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x203a62 
09-26 22:19:07.239+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb91e0280. set autocapital type : 2
09-26 22:19:07.239+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 22:19:07.239+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 1e410025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 22:19:07.239+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb91e0280. on demand : 0
09-26 22:19:07.249+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 22:19:07.249+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb91e0280, cursor pos : 0
09-26 22:19:08.149+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_down_cb(582) > XF86Back key is pressed.
09-26 22:19:08.149+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:08.149+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:08.249+0900 D/IMMODULE( 7731): isf_imf_context.cpp: _key_up_cb(629) > XF86Back key is released.
09-26 22:19:08.249+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 1
09-26 22:19:08.249+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:1
09-26 22:19:08.249+0900 D/IMMODULE( 7731): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb91e0280
09-26 22:19:08.249+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 22:19:08.249+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb91e0280
09-26 22:19:08.249+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 22:19:08.299+0900 D/IMMODULE( 7731): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
09-26 22:19:08.299+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 38 38
09-26 22:19:08.299+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
09-26 22:19:08.299+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
09-26 22:19:08.299+0900 D/ISF_PANEL_EFL( 3136): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:08.299+0900 D/SCIM_HELPER( 3149): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
09-26 22:19:08.299+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2800009 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:08.409+0900 D/LIBSCL_UI( 3149): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2800003 (basewin 0x8000321a mag 0x8000fc7f)
09-26 22:19:08.409+0900 D/ISE_DEFAULT( 3149): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
09-26 22:19:08.679+0900 W/CRASH_MANAGER( 7733): worker.c: worker_job(1204) > 1107731636861147489594
