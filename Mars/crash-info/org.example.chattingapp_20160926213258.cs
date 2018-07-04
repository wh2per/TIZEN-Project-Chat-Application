S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: chattingapp
PID: 5495
Date: 2016-09-26 21:32:58+0900
Executable File Path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb98e0f98, esi = 0xb98a2848
ebp = 0xbfef9808, esp = 0xbfef97bc
eax = 0x00000062, ebx = 0xb35402a0
ecx = 0xb647c024, edx = 0x00000000
eip = 0xb6ccfae3

Memory Information
MemTotal:      123 KB
MemFree:        22 KB
Buffers:         3 KB
Cached:     200400 KB
VmPeak:     116400 KB
VmSize:     116400 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23228 KB
VmRSS:       23228 KB
VmData:      51852 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33536 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 5495 TID = 5495
5495 5497 5719 5723 5724 5729 

Maps Information
b1b1a000 b1b21000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1b63000 b1b7b000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b7c000 b1b83000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2385000 b238f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2395000 b23a1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b23a2000 b23c3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b23c8000 b23c9000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b23ca000 b23cf000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b23d0000 b23d1000 r-xp /usr/lib/libxshmfence.so.1.0.0
b23d2000 b23d4000 r-xp /usr/lib/libxcb-present.so.0.0.0
b23d5000 b23d7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b23d8000 b23e4000 r-xp /usr/lib/libdrm.so.2.4.0
b23e5000 b23e8000 r-xp /usr/lib/libdri2.so.0.0.0
b23e9000 b23fe000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d01000 b2d0b000 r-xp /usr/lib/libtbm.so.1.0.0
b2d0c000 b2d0d000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2d0e000 b2d20000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3522000 b352b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b352c000 b3540000 r-xp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
b3648000 b364e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b364f000 b3793000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37a9000 b37aa000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b37ab000 b37ac000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b37ad000 b37b0000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b37b1000 b37b4000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b37b5000 b37ee000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41f1000 b41fc000 r-xp /lib/libnss_files-2.20-2014.11.so
b41fe000 b4209000 r-xp /lib/libnss_nis-2.20-2014.11.so
b420b000 b4222000 r-xp /lib/libnsl-2.20-2014.11.so
b4226000 b422e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4230000 b4254000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4255000 b4256000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4257000 b425a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b425b000 b4262000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4263000 b426d000 r-xp /usr/lib/libsensord-share.so
b426e000 b428a000 r-xp /usr/lib/libsensor.so.1.2.0
b428c000 b4295000 r-xp /usr/lib/libappcore-common.so.1.1
b4298000 b429a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42af000 b42b1000 r-xp /usr/lib/libXau.so.6.0.0
b42b2000 b42d4000 r-xp /usr/lib/libxcb.so.1.1.0
b42d6000 b42df000 r-xp /lib/libcrypt-2.20-2014.11.so
b4308000 b430a000 r-xp /usr/lib/libiri.so
b430b000 b4331000 r-xp /lib/libexpat.so.1.5.2
b4333000 b439e000 r-xp /usr/lib/libssl.so.1.0.0
b43a4000 b43b0000 r-xp /usr/lib/libethumb.so.1.13.0
b43b1000 b43b5000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43b6000 b4607000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b82000 b5b92000 r-xp /usr/lib/libXi.so.6.1.0
b5b93000 b5b95000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b96000 b5b9c000 r-xp /usr/lib/libXtst.so.6.1.0
b5b9d000 b5ba7000 r-xp /usr/lib/libXrender.so.1.3.0
b5ba8000 b5bb1000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bb3000 b5bb5000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bb6000 b5bbb000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bbc000 b5bce000 r-xp /usr/lib/libXext.so.6.4.0
b5bcf000 b5bd1000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bd2000 b5bd4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bd6000 b5d18000 r-xp /usr/lib/libX11.so.6.3.0
b5d1c000 b5d26000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d27000 b5d3d000 r-xp /usr/lib/libudev.so.1.6.0
b5d40000 b5d44000 r-xp /lib/libattr.so.1.1.0
b5d45000 b5d74000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d76000 b5d7c000 r-xp /usr/lib/libffi.so.6.0.2
b5d7d000 b5da0000 r-xp /lib/libz.so.1.2.8
b5da1000 b5da4000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5da5000 b5f01000 r-xp /usr/lib/libxml2.so.2.9.2
b5f07000 b5fee000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ffb000 b5ffe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fff000 b6021000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6022000 b6036000 r-xp /lib/libresolv-2.20-2014.11.so
b603a000 b605e000 r-xp /usr/lib/liblzma.so.5.0.3
b605f000 b6061000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6063000 b606d000 r-xp /usr/lib/libembryo.so.1.13.0
b606e000 b6097000 r-xp /usr/lib/libpng12.so.0.50.0
b6098000 b60e1000 r-xp /usr/lib/libjpeg.so.8.0.2
b60f2000 b60f9000 r-xp /lib/librt-2.20-2014.11.so
b60fb000 b611a000 r-xp /usr/lib/libector.so.1.13.0
b611d000 b614a000 r-xp /usr/lib/liblua-5.1.so
b614b000 b61db000 r-xp /usr/lib/libfreetype.so.6.11.3
b61df000 b621d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b621e000 b6234000 r-xp /usr/lib/libfribidi.so.0.3.1
b6235000 b628e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6291000 b62dc000 r-xp /lib/libm-2.20-2014.11.so
b62de000 b62f0000 r-xp /usr/lib/libeio.so.1.13.0
b62f1000 b62f4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62f5000 b62fb000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62fc000 b631f000 r-xp /usr/lib/libefreet.so.1.13.0
b6322000 b634d000 r-xp /usr/lib/libeldbus.so.1.13.0
b634e000 b6382000 r-xp /usr/lib/libecore_con.so.1.13.0
b6384000 b638d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b638e000 b6397000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6398000 b63ab000 r-xp /usr/lib/libeo.so.1.13.0
b63ad000 b63c0000 r-xp /usr/lib/libecore_input.so.1.13.0
b63c1000 b63c8000 r-xp /usr/lib/libecore_file.so.1.13.0
b63c9000 b63ec000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ed000 b6419000 r-xp /usr/lib/libeet.so.1.13.0
b6422000 b648d000 r-xp /usr/lib/libeina.so.1.13.0
b6490000 b64a7000 r-xp /usr/lib/libefl.so.1.13.0
b64a9000 b6610000 r-xp /usr/lib/libicuuc.so.51.1
b661e000 b682a000 r-xp /usr/lib/libicui18n.so.51.1
b6832000 b6881000 r-xp /usr/lib/libecore_x.so.1.13.0
b6883000 b689d000 r-xp /lib/libgcc_s-4.9.so.1
b689f000 b68a3000 r-xp /lib/libcap.so.2.21
b68a4000 b68ea000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68eb000 b68f2000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68f4000 b6946000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6948000 b6ad3000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ad8000 b6ba6000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ba9000 b6bad000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bae000 b6bbd000 r-xp /usr/lib/libvconf.so.0.2.45
b6bbe000 b6bc1000 r-xp /usr/lib/libvasum.so.0.3.1
b6bc2000 b6bc5000 r-xp /usr/lib/libttrace.so.1.1
b6bc7000 b6bcb000 r-xp /usr/lib/libiniparser.so.0
b6bcc000 b6bfc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bfd000 b6c06000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c07000 b6c2c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c2d000 b6c3d000 r-xp /usr/lib/libunwind.so.8.0.1
b6c47000 b6df5000 r-xp /lib/libc-2.20-2014.11.so
b6dfd000 b6f40000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f42000 b6f9a000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f9b000 b6fcf000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fd2000 b70a6000 r-xp /usr/lib/libedje.so.1.13.0
b70a9000 b70d5000 r-xp /usr/lib/libecore.so.1.13.0
b70e6000 b730c000 r-xp /usr/lib/libevas.so.1.13.0
b7334000 b734c000 r-xp /lib/libpthread-2.20-2014.11.so
b7350000 b76ca000 r-xp /usr/lib/libelementary.so.1.13.0
b76ea000 b76ee000 r-xp /usr/lib/libsmack.so.1.0.0
b76ef000 b76f8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76f9000 b76fc000 r-xp /usr/lib/libdlog.so.0.0.0
b76fd000 b7702000 r-xp /usr/lib/libbundle.so.0.1.22
b7703000 b7706000 r-xp /lib/libdl-2.20-2014.11.so
b7708000 b772d000 r-xp /usr/lib/libaul.so.0.1.0
b7730000 b7732000 r-xp /usr/lib/libappsvc.so.0.1.0
b7733000 b7738000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7739000 b7740000 r-xp /usr/lib/libappcore-efl.so.1.1
b7742000 b7747000 r-xp /usr/lib/libsys-assert.so
b774a000 b774b000 r-xp [vdso]
b774b000 b776d000 r-xp /lib/ld-2.20-2014.11.so
b776f000 b7777000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5495)
Call Stack Count: 22
 0: (0xb6ccfae3) [/lib/libc.so.6] + 0x88ae3
 1: (0xb716f116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63a6319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63a3d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71719e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7422404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb7055f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb705ca11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb7056fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70574cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb705768f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70bc702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70b6055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70bf1b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70bf587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb751822d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb773cdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb7735c40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: app_run + 0x1cb (0xb353c0ab) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x100ab
19: main + 0x258 (0xb353dff8) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x11ff8
20: (0xb7771148) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xb7771148
21: __libc_start_main + 0xde (0xb6c5ee4e) [/lib/libc.so.6] + 0x17e4e
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
1:32:47.934+0900 D/QUICKPANEL( 3034): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.chattingapp key:end val:ok
09-26 21:32:47.934+0900 D/PKGMGR  ( 5661): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:32:47.934+0900 D/PKGMGR  ( 3136): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:32:47.934+0900 D/PKGMGR  ( 3136): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:32:47.934+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.chattingapp event_type=UPDATE event_state=COMPLETED progress=100 error=0
09-26 21:32:47.934+0900 W/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
09-26 21:32:47.934+0900 D/PKGMGR  ( 3030): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:32:47.934+0900 D/DATA_PROVIDER_MASTER( 3030): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.chattingapp] ok
09-26 21:32:47.934+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.chattingapp], event_type[1]
09-26 21:32:47.934+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
09-26 21:32:47.934+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
09-26 21:32:47.934+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
09-26 21:32:47.934+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.chattingapp]
09-26 21:32:47.934+0900 D/PKGMGR  ( 3051): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
09-26 21:32:47.934+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:32:47.934+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29840003] pkg_type[tpk] package[org.example.chattingapp] key[install_percent] val[100] pmsg[(null)]
09-26 21:32:47.934+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:32:47.934+0900 W/cluster-home( 2984): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.chattingapp]
09-26 21:32:47.934+0900 D/cluster-home( 2984): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.chattingapp]
09-26 21:32:47.934+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:32:47.934+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29840003] pkg_type[tpk] package[org.example.chattingapp] key[end] val[ok] pmsg[(null)]
09-26 21:32:47.934+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
09-26 21:32:47.934+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
09-26 21:32:47.934+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
09-26 21:32:47.934+0900 D/PKGMGR  ( 3056): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:32:47.934+0900 D/PKGMGR  ( 2879): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.chattingapp_1398302127], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:32:47.934+0900 D/AUL_AMD ( 2879): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.chattingapp), key(end), value(ok)
09-26 21:32:47.934+0900 W/AUL_AMD ( 2879): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
09-26 21:32:47.944+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
09-26 21:32:47.944+0900 D/AUL_AMD ( 2879): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.chattingapp, type:rpm
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.chattingapp]
09-26 21:32:47.954+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.chattingapp]
09-26 21:32:47.954+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.chattingapp]
09-26 21:32:47.954+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
09-26 21:32:47.954+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
09-26 21:32:47.954+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.chattingapp]
09-26 21:32:47.954+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.chattingapp] Name[chattingapp] Icon[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png] enable[1] system[0]
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.chattingapp]
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.chattingapp
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.chattingapp], name[chattingapp], menuId[1], isPreload[0] isPreload[0]
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
09-26 21:32:47.954+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.chattingapp] Name[chattingapp] Icon[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png] enable[1] system[0]
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [chattingapp]
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
09-26 21:32:47.954+0900 D/test-log( 2984): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png], New icon path[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png]!!!!!
09-26 21:32:47.954+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
09-26 21:32:48.204+0900 D/rpm-installer( 5666): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
09-26 21:32:48.204+0900 D/rpm-installer( 5666): rpm-appcore-intf.c: main(259) > ------------------------------------------------
09-26 21:32:48.204+0900 D/rpm-installer( 5666): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
09-26 21:32:48.204+0900 D/rpm-installer( 5666): rpm-appcore-intf.c: main(261) > ------------------------------------------------
09-26 21:32:48.204+0900 D/PKGMGR_SERVER( 5663): pkgmgr-server.c: sighandler(387) > child exit [5666]
09-26 21:32:48.204+0900 E/PKGMGR_SERVER( 5663): pkgmgr-server.c: sighandler(402) > child NORMAL exit [5666]
09-26 21:32:49.884+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 0
09-26 21:32:49.884+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.chattingapp
09-26 21:32:49.884+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
09-26 21:32:49.884+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
09-26 21:32:49.884+0900 I/AUL     ( 2879): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
09-26 21:32:49.884+0900 D/AUL     ( 2879): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 5716, pid = 5718
09-26 21:32:49.884+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
09-26 21:32:49.884+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
09-26 21:32:49.884+0900 I/AUL     ( 2879): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
09-26 21:32:49.884+0900 E/AUL_AMD ( 2879): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
09-26 21:32:49.884+0900 W/AUL_AMD ( 2879): amd_launch.c: _start_app(2233) > caller pid : 5718
09-26 21:32:49.884+0900 E/AUL_AMD ( 2879): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
09-26 21:32:49.884+0900 W/AUL_AMD ( 2879): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.chattingapp) pkgid(org.example.chattingapp) attribute(600)
09-26 21:32:49.884+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2648) > process_pool: false
09-26 21:32:49.884+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
09-26 21:32:49.884+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.chattingapp
09-26 21:32:49.884+0900 W/AUL_AMD ( 2879): amd_launch.c: _start_app(2665) > pad pid(-5)
09-26 21:32:49.884+0900 D/AUL_AMD ( 2879): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
09-26 21:32:49.884+0900 D/AUL_AMD ( 2879): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
09-26 21:32:49.884+0900 D/AUL     ( 2879): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.chattingapp
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
09-26 21:32:49.884+0900 W/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
09-26 21:32:49.884+0900 D/AUL     ( 3028): process_pool.c: __send_pkt_raw_data(219) > send(13) : 644 / 644
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5495, bin path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:32:49.884+0900 W/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(265) > Check app launching
09-26 21:32:49.884+0900 D/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
09-26 21:32:49.884+0900 D/RESOURCED( 2954): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.chattingapp, pkgid = org.example.chattingapp, flags = 1536
09-26 21:32:49.884+0900 D/RESOURCED( 2954): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.chattingapp, pkgname = org.example.chattingapp, ref = 1
09-26 21:32:49.884+0900 E/RESOURCED( 2954): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 644, pkt->len: 636
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.chattingapp, launchpad type: 0
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.chattingapp
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.chattingapp
09-26 21:32:49.894+0900 D/AUL     ( 5495): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5497) is sent.
09-26 21:32:49.894+0900 D/AUL     ( 5495): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5497, signo: 10
09-26 21:32:49.894+0900 D/AUL     ( 5495): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.chattingapp / pkg_type : rpm / app_path : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.chattingapp/bin/chattingapp##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzQ4OTMxNjkvODkzMjcyAA==##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1NzE4AA==##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.chattingapp/bin/chattingapp, real app argc: 8
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
09-26 21:32:49.894+0900 D/AUL_PAD ( 5495): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.chattingapp/bin/chattingapp)
09-26 21:32:49.904+0900 I/CAPI_APPFW_APPLICATION( 5495): app_main.c: ui_app_main(788) > app_efl_main
09-26 21:32:49.904+0900 D/LAUNCH  ( 5495): appcore-efl.c: appcore_efl_main(1692) > [chattingapp:Application:main:done]
09-26 21:32:49.904+0900 D/APP_CORE( 5495): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
09-26 21:32:49.904+0900 D/APP_CORE( 5495): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.chattingapp/res/locale
09-26 21:32:49.904+0900 D/APP_CORE( 5495): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
09-26 21:32:49.914+0900 D/APP_CORE( 5495): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
09-26 21:32:49.914+0900 D/AUL     ( 5495): app_sock.c: __create_server_sock(156) > pg path - already exists
09-26 21:32:49.914+0900 D/APP_CORE( 5495): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4295520
09-26 21:32:49.914+0900 D/LAUNCH  ( 5495): appcore-efl.c: __before_loop(1136) > [chattingapp:Platform:appcore_init:done]
09-26 21:32:49.914+0900 I/CAPI_APPFW_APPLICATION( 5495): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
09-26 21:32:49.974+0900 E/E17     ( 2793): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02600002)
09-26 21:32:49.984+0900 D/IMMODULE( 5495): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
09-26 21:32:49.984+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:32:49.984+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:32:49.984+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:32:49.984+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:32:49.984+0900 E/E17     ( 2793): e_border.c: e_border_show(2088) > BD_SHOW(0x02600002)
09-26 21:32:49.994+0900 D/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
09-26 21:32:49.994+0900 E/PKGMGR_SERVER( 5663): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-26 21:32:49.994+0900 E/PKGMGR_SERVER( 5663): pkgmgr-server.c: main(2265) > package manager server terminated.
09-26 21:32:49.994+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5495, appid: org.example.chattingapp
09-26 21:32:49.994+0900 D/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
09-26 21:32:49.994+0900 E/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(330) > access
09-26 21:32:49.994+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2700) > add app group info
09-26 21:32:49.994+0900 E/AUL     ( 2879): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
09-26 21:32:49.994+0900 D/AUL_AMD ( 2879): amd_status.c: _status_add_app_info_list(427) > pid(5495) appid(org.example.chattingapp) pkgid(org.example.chattingapp) comp(uiapp)
09-26 21:32:49.994+0900 W/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5495
09-26 21:32:49.994+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 21:32:49.994+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 21:32:49.994+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:32:49.994+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:32:50.024+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 15
09-26 21:32:50.024+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:32:50.024+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:32:50.024+0900 D/INDICATOR( 2958): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
09-26 21:32:50.024+0900 D/INDICATOR( 2958): util.c: util_signal_emit_by_win(116) > emission bg.opaque
09-26 21:32:50.024+0900 D/INDICATOR( 2958): main.c: _rotate_window(229) > Indicator angle is 0 degree
09-26 21:32:50.024+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
09-26 21:32:50.024+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
09-26 21:32:50.024+0900 D/INDICATOR( 2958): main.c: _rotate_window(252) > port :: hide more icon
09-26 21:32:50.024+0900 D/AUL_AMD ( 2879): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5495 is org.example.chattingapp
09-26 21:32:50.024+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5495 : 0
09-26 21:32:50.024+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.chattingapp, 5495
09-26 21:32:50.024+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.chattingapp with pkgname
09-26 21:32:50.024+0900 E/RESOURCED( 2954): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.chattingapp
09-26 21:32:50.024+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(888) > available memory = 307
09-26 21:32:50.024+0900 D/AUL     ( 3056): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 32
09-26 21:32:50.024+0900 D/ISF_QUERY( 5495): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
09-26 21:32:50.024+0900 D/ISF_QUERY( 5495): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:32:50.024+0900 D/ISF_QUERY( 5495): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:32:50.024+0900 D/ISF_QUERY( 5495): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:32:50.024+0900 D/ISF_QUERY( 5495): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:32:50.024+0900 D/ISF_QUERY( 5495): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:32:50.024+0900 D/ISF_QUERY( 5495): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:32:50.024+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:32:50.024+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:32:50.024+0900 D/IMMODULE( 5495): scim_panel_client.cpp: open_connection(162) > 
09-26 21:32:50.024+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 21:32:50.024+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:32:50.034+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 21:32:50.034+0900 D/ISF_SOCKET( 5495): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:32:50.054+0900 D/IMMODULE( 5495): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
09-26 21:32:50.094+0900 D/LAUNCH  ( 5495): appcore-efl.c: __before_loop(1154) > [chattingapp:Application:create:done]
09-26 21:32:50.134+0900 D/APP_CORE( 5495): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
09-26 21:32:50.154+0900 D/APP_CORE( 5495): appcore.c: __aul_handler(587) > [APP 5495]     AUL event: AUL_START
09-26 21:32:50.154+0900 I/APP_CORE( 5495): appcore-efl.c: __do_app(496) > [APP 5495] Event: RESET State: CREATED
09-26 21:32:50.154+0900 D/APP_CORE( 5495): appcore-efl.c: __do_app(527) > [APP 5495] RESET
09-26 21:32:50.154+0900 D/LAUNCH  ( 5495): appcore-efl.c: __do_app(529) > [chattingapp:Application:reset:start]
09-26 21:32:50.154+0900 D/APP_CORE( 5495): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
09-26 21:32:50.154+0900 D/APP_CORE( 5495): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 21:32:50.154+0900 I/CAPI_APPFW_APPLICATION( 5495): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
09-26 21:32:50.154+0900 D/AUL     ( 5495): service.c: __set_bundle(186) > __set_bundle
09-26 21:32:50.154+0900 D/LAUNCH  ( 5495): appcore-efl.c: __do_app(544) > [chattingapp:Application:reset:done]
09-26 21:32:50.154+0900 D/APP_CORE( 5495): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
09-26 21:32:50.154+0900 E/EFL     ( 5495): edje<5495> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:32:50.154+0900 E/EFL     ( 5495): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:32:50.154+0900 E/EFL     ( 5495): edje<5495> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:32:50.154+0900 E/EFL     ( 5495): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:32:50.154+0900 E/EFL     ( 5495): edje<5495> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:32:50.154+0900 E/EFL     ( 5495): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:32:50.174+0900 W/APP_CORE( 5495): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
09-26 21:32:50.174+0900 D/APP_CORE( 5495): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2600002
09-26 21:32:50.174+0900 D/APP_CORE( 5495): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
09-26 21:32:50.174+0900 D/AUL     ( 5495): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
09-26 21:32:50.184+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 34
09-26 21:32:50.204+0900 D/IMMODULE( 5495): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb98ba8d8. set autocapital type : 2
09-26 21:32:50.204+0900 D/IMMODULE( 5495): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb98ba8d8. on demand : 0
09-26 21:32:50.204+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 21:32:50.204+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 15770025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 21:32:50.204+0900 D/IMMODULE( 5495): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 21:32:50.204+0900 D/IMMODULE( 5495): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98ba8d8, cursor pos : 0
09-26 21:32:50.324+0900 D/APP_CORE( 5495): appcore.c: __prt_ltime(236) > [APP 5495] first idle after reset: 446 msec
09-26 21:32:50.374+0900 E/E17     ( 2793): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
09-26 21:32:50.374+0900 D/APP_CORE( 5495): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2600002 fully_obscured 0
09-26 21:32:50.374+0900 D/APP_CORE( 5495): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
09-26 21:32:50.374+0900 D/APP_CORE( 5495): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
09-26 21:32:50.374+0900 I/APP_CORE( 5495): appcore-efl.c: __do_app(496) > [APP 5495] Event: RESUME State: CREATED
09-26 21:32:50.374+0900 D/LAUNCH  ( 5495): appcore-efl.c: __do_app(597) > [chattingapp:Application:resume:start]
09-26 21:32:50.374+0900 D/APP_CORE( 5495): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
09-26 21:32:50.374+0900 D/APP_CORE( 5495): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 21:32:50.374+0900 D/APP_CORE( 5495): appcore-efl.c: __do_app(607) > [APP 5495] RESUME
09-26 21:32:50.374+0900 D/APP_CORE( 2984): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
09-26 21:32:50.374+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
09-26 21:32:50.374+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
09-26 21:32:50.374+0900 I/APP_CORE( 2984): appcore-efl.c: __do_app(496) > [APP 2984] Event: PAUSE State: RUNNING
09-26 21:32:50.374+0900 D/APP_CORE( 2984): appcore-efl.c: __do_app(565) > [APP 2984] PAUSE
09-26 21:32:50.374+0900 I/CAPI_APPFW_APPLICATION( 2984): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
09-26 21:32:50.374+0900 E/cluster-home( 2984): homescreen.cpp: OnPause(84) >  app pause
09-26 21:32:50.374+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
09-26 21:32:50.374+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(923) >  END
09-26 21:32:50.374+0900 D/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 21:32:50.374+0900 E/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 21:32:50.374+0900 I/APP_CORE( 5495): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
09-26 21:32:50.374+0900 I/APP_CORE( 5495): appcore-efl.c: __do_app(614) > [APP 5495] Initial Launching, call the resume_cb
09-26 21:32:50.374+0900 I/CAPI_APPFW_APPLICATION( 5495): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
09-26 21:32:50.374+0900 D/LAUNCH  ( 5495): appcore-efl.c: __do_app(636) > [chattingapp:Application:resume:done]
09-26 21:32:50.374+0900 D/LAUNCH  ( 5495): appcore-efl.c: __do_app(638) > [chattingapp:Application:Launching:done]
09-26 21:32:50.374+0900 D/APP_CORE( 5495): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 21:32:50.374+0900 E/APP_CORE( 5495): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 21:32:50.374+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(2984) status(4)
09-26 21:32:50.374+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(2984) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
09-26 21:32:50.374+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
09-26 21:32:50.374+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2984, appid: org.tizen.homescreen, status: bg
09-26 21:32:50.374+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2891) > pid(5495) status(3)
09-26 21:32:50.374+0900 D/AUL_AMD ( 2879): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
09-26 21:32:50.374+0900 W/AUL_AMD ( 2879): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-26 21:32:50.374+0900 W/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
09-26 21:32:50.374+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(5495) status(3)
09-26 21:32:50.374+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(5495) appid(org.example.chattingapp) pkgid(org.example.chattingapp) status(3)
09-26 21:32:50.374+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.chattingapp
09-26 21:32:50.374+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5495, appid: org.example.chattingapp, status: fg
09-26 21:32:50.374+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5495
09-26 21:32:50.374+0900 D/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5495, proc_name: org.example.chattingapp, cg_name: foreground, oom_score_adj: 200
09-26 21:32:50.374+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5495
09-26 21:32:50.384+0900 D/DATA_PROVIDER_MASTER( 3030): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2984 is paused
09-26 21:32:50.384+0900 D/DATA_PROVIDER_MASTER( 3030): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
09-26 21:32:50.434+0900 D/RESOURCED( 2954): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5495, appname = org.example.chattingapp, pkgname = org.example.chattingapp
09-26 21:32:50.434+0900 D/RESOURCED( 2954): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5495, appname = org.example.chattingapp
09-26 21:32:50.434+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5495
09-26 21:32:50.434+0900 I/RESOURCED( 2954): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
09-26 21:32:50.434+0900 I/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
09-26 21:32:50.564+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2910) > pid(5495) status(0)
09-26 21:32:50.994+0900 D/AUL_PAD ( 3028): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
09-26 21:32:50.994+0900 D/AUL_PAD ( 5727): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
09-26 21:32:50.994+0900 D/AUL_PAD ( 3028): sigchild.h: __send_app_launch_signal(131) > send launch signal done
09-26 21:32:51.014+0900 E/RESOURCED( 2954): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.359
09-26 21:32:51.494+0900 D/AUL_AMD ( 2879): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.chattingapp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:32:51.494+0900 D/RUA     ( 2879): rua.c: rua_add_history(179) > rua_add_history start
09-26 21:32:51.504+0900 D/RUA     ( 2879): rua.c: rua_add_history(247) > rua_add_history ok
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): launchpad_loader.c: main(588) > sleeping 1 sec...
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(52) > max_cmdline_size = 1053
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8ca3760
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(69) > get pre-initialization function
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(73) > get shutdown function
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8ca3a40
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8ca5640
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(69) > get pre-initialization function
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preload.h: __preload_init(73) > get shutdown function
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): preexec.h: __preexec_init(76) > preexec start
09-26 21:32:52.034+0900 D/AUL_PAD ( 5727): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
09-26 21:32:52.044+0900 D/AUL     ( 5727): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
09-26 21:32:52.044+0900 D/AUL     ( 5727): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
09-26 21:32:52.044+0900 D/AUL     ( 5727): process_pool.c: __connect_to_launchpad(132) > send(5727) : 4
09-26 21:32:52.044+0900 D/AUL     ( 5727): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
09-26 21:32:52.044+0900 D/AUL_PAD ( 3028): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5727
09-26 21:32:52.044+0900 E/RESOURCED( 2954): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.360
09-26 21:32:52.124+0900 D/AUL_PAD ( 5727): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
09-26 21:32:52.134+0900 D/AUL_PAD ( 5727): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
09-26 21:32:52.134+0900 D/AUL_PAD ( 5727): launchpad_loader.c: main(693) > [candidate] ecore handler add
09-26 21:32:52.134+0900 D/AUL_PAD ( 5727): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
09-26 21:32:55.373+0900 D/APP_CORE( 2984): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
09-26 21:32:55.373+0900 I/APP_CORE( 2984): appcore-efl.c: __do_app(496) > [APP 2984] Event: MEM_FLUSH State: PAUSED
09-26 21:32:55.373+0900 D/APP_CORE( 2984): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
09-26 21:32:55.373+0900 D/APP_CORE( 2984): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2984
09-26 21:32:55.373+0900 D/APP_CORE( 2984): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
09-26 21:32:55.373+0900 D/RESOURCED( 2954): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2984
09-26 21:32:55.743+0900 E/CAPI_NETWORK_WIFI( 2958): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
09-26 21:32:55.743+0900 E/INDICATOR( 2958): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
09-26 21:32:55.743+0900 E/INDICATOR( 2958): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
09-26 21:32:55.743+0900 E/INDICATOR( 2958): 
09-26 21:32:57.443+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2020d0 
09-26 21:32:57.443+0900 D/IMMODULE( 5495): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb98ba8d8
09-26 21:32:57.443+0900 D/IMMODULE( 5495): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 21:32:57.763+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2020d0 
09-26 21:32:57.953+0900 D/IMMODULE( 5495): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb98ba8d8, cursor pos : 1
09-26 21:32:57.953+0900 D/IMMODULE( 5495): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb98ba8d8, bidi direction : 0x1
09-26 21:32:58.413+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x2020d0 
09-26 21:32:58.433+0900 D/IMMODULE( 5495): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb98ba8d8
09-26 21:32:58.433+0900 D/IMMODULE( 5495): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 21:32:58.433+0900 D/IMMODULE( 5495): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb98ba8d8
09-26 21:32:58.433+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 21:32:58.633+0900 D/AUL_PAD ( 3028): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
09-26 21:32:58.633+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
09-26 21:32:58.633+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
09-26 21:32:58.633+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
09-26 21:32:58.633+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
09-26 21:32:58.633+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
09-26 21:32:58.633+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
09-26 21:32:58.633+0900 I/AUL_PAD ( 3028): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 5495 pgid = 5495
09-26 21:32:58.633+0900 I/AUL_PAD ( 3028): sigchild.h: __sigchild_action(142) > dead_pid(5495)
09-26 21:32:58.643+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 21:32:58.653+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2891) > pid(2984) status(3)
09-26 21:32:58.653+0900 D/AUL_AMD ( 2879): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
09-26 21:32:58.653+0900 W/AUL_AMD ( 2879): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-26 21:32:58.653+0900 W/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
09-26 21:32:58.653+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(2984) status(3)
09-26 21:32:58.653+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(2984) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
09-26 21:32:58.653+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
09-26 21:32:58.653+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2984, appid: org.tizen.homescreen, status: fg
09-26 21:32:58.653+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2984
09-26 21:32:58.653+0900 D/RESOURCED( 2954): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2984, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
09-26 21:32:58.653+0900 D/RESOURCED( 2954): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2984, appname = org.tizen.homescreen
09-26 21:32:58.653+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2984
09-26 21:32:58.663+0900 W/CRASH_MANAGER( 5730): worker.c: worker_job(1204) > 1105495636861147489317
