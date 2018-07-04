S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: chattingapp
PID: 5266
Date: 2016-09-26 21:28:52+0900
Executable File Path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x84

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb35140e4, esi = 0xb929b818
ebp = 0xbfa60c38, esp = 0xbfa60c10
eax = 0x80065d30, ebx = 0xb35162a0
ecx = 0x00000000, edx = 0x00000002
eip = 0xb3511c4d

Memory Information
MemTotal:      123 KB
MemFree:        22 KB
Buffers:         3 KB
Cached:     200348 KB
VmPeak:     116532 KB
VmSize:     116532 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23264 KB
VmRSS:       23264 KB
VmData:      51984 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33536 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 5266 TID = 5266
5266 5274 5488 5492 5493 5496 

Maps Information
b2c29000 b2c30000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b2c3c000 b2c54000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2c55000 b2c5c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2c5d000 b2c67000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c6d000 b2c79000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c7a000 b2c9b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2ca0000 b2ca1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2ca2000 b2ca7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ca8000 b2ca9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2caa000 b2cac000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2cad000 b2caf000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2cb0000 b2cbc000 r-xp /usr/lib/libdrm.so.2.4.0
b2cbd000 b2cc0000 r-xp /usr/lib/libdri2.so.0.0.0
b2cc1000 b2ccb000 r-xp /usr/lib/libtbm.so.1.0.0
b2ccc000 b2ccd000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2cce000 b2ce3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2ce4000 b2cf6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b34f8000 b3501000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3502000 b3516000 r-xp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
b361e000 b3624000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3625000 b3769000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b377f000 b3780000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3781000 b3782000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3783000 b3786000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3787000 b378a000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b378b000 b37c4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c7000 b41d2000 r-xp /lib/libnss_files-2.20-2014.11.so
b41d4000 b41df000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41e1000 b41f8000 r-xp /lib/libnsl-2.20-2014.11.so
b41fc000 b4204000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4206000 b422a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b422b000 b422c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b422d000 b4230000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4231000 b4238000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4239000 b4243000 r-xp /usr/lib/libsensord-share.so
b4244000 b4260000 r-xp /usr/lib/libsensor.so.1.2.0
b4262000 b426b000 r-xp /usr/lib/libappcore-common.so.1.1
b426e000 b4270000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4285000 b4287000 r-xp /usr/lib/libXau.so.6.0.0
b4288000 b42aa000 r-xp /usr/lib/libxcb.so.1.1.0
b42ac000 b42b5000 r-xp /lib/libcrypt-2.20-2014.11.so
b42de000 b42e0000 r-xp /usr/lib/libiri.so
b42e1000 b4307000 r-xp /lib/libexpat.so.1.5.2
b4309000 b4374000 r-xp /usr/lib/libssl.so.1.0.0
b437a000 b4386000 r-xp /usr/lib/libethumb.so.1.13.0
b4387000 b438b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b438c000 b45dd000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b58000 b5b68000 r-xp /usr/lib/libXi.so.6.1.0
b5b69000 b5b6b000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b6c000 b5b72000 r-xp /usr/lib/libXtst.so.6.1.0
b5b73000 b5b7d000 r-xp /usr/lib/libXrender.so.1.3.0
b5b7e000 b5b87000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b89000 b5b8b000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b8c000 b5b91000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b92000 b5ba4000 r-xp /usr/lib/libXext.so.6.4.0
b5ba5000 b5ba7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba8000 b5baa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bac000 b5cee000 r-xp /usr/lib/libX11.so.6.3.0
b5cf2000 b5cfc000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cfd000 b5d13000 r-xp /usr/lib/libudev.so.1.6.0
b5d16000 b5d1a000 r-xp /lib/libattr.so.1.1.0
b5d1b000 b5d4a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d4c000 b5d52000 r-xp /usr/lib/libffi.so.6.0.2
b5d53000 b5d76000 r-xp /lib/libz.so.1.2.8
b5d77000 b5d7a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d7b000 b5ed7000 r-xp /usr/lib/libxml2.so.2.9.2
b5edd000 b5fc4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fd1000 b5fd4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fd5000 b5ff7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff8000 b600c000 r-xp /lib/libresolv-2.20-2014.11.so
b6010000 b6034000 r-xp /usr/lib/liblzma.so.5.0.3
b6035000 b6037000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6039000 b6043000 r-xp /usr/lib/libembryo.so.1.13.0
b6044000 b606d000 r-xp /usr/lib/libpng12.so.0.50.0
b606e000 b60b7000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c8000 b60cf000 r-xp /lib/librt-2.20-2014.11.so
b60d1000 b60f0000 r-xp /usr/lib/libector.so.1.13.0
b60f3000 b6120000 r-xp /usr/lib/liblua-5.1.so
b6121000 b61b1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b5000 b61f3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61f4000 b620a000 r-xp /usr/lib/libfribidi.so.0.3.1
b620b000 b6264000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6267000 b62b2000 r-xp /lib/libm-2.20-2014.11.so
b62b4000 b62c6000 r-xp /usr/lib/libeio.so.1.13.0
b62c7000 b62ca000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62cb000 b62d1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62d2000 b62f5000 r-xp /usr/lib/libefreet.so.1.13.0
b62f8000 b6323000 r-xp /usr/lib/libeldbus.so.1.13.0
b6324000 b6358000 r-xp /usr/lib/libecore_con.so.1.13.0
b635a000 b6363000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6364000 b636d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b636e000 b6381000 r-xp /usr/lib/libeo.so.1.13.0
b6383000 b6396000 r-xp /usr/lib/libecore_input.so.1.13.0
b6397000 b639e000 r-xp /usr/lib/libecore_file.so.1.13.0
b639f000 b63c2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63c3000 b63ef000 r-xp /usr/lib/libeet.so.1.13.0
b63f8000 b6463000 r-xp /usr/lib/libeina.so.1.13.0
b6466000 b647d000 r-xp /usr/lib/libefl.so.1.13.0
b647f000 b65e6000 r-xp /usr/lib/libicuuc.so.51.1
b65f4000 b6800000 r-xp /usr/lib/libicui18n.so.51.1
b6808000 b6857000 r-xp /usr/lib/libecore_x.so.1.13.0
b6859000 b6873000 r-xp /lib/libgcc_s-4.9.so.1
b6875000 b6879000 r-xp /lib/libcap.so.2.21
b687a000 b68c0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68c1000 b68c8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68ca000 b691c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b691e000 b6aa9000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aae000 b6b7c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b7f000 b6b83000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b84000 b6b93000 r-xp /usr/lib/libvconf.so.0.2.45
b6b94000 b6b97000 r-xp /usr/lib/libvasum.so.0.3.1
b6b98000 b6b9b000 r-xp /usr/lib/libttrace.so.1.1
b6b9d000 b6ba1000 r-xp /usr/lib/libiniparser.so.0
b6ba2000 b6bd2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bd3000 b6bdc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bdd000 b6c02000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c03000 b6c13000 r-xp /usr/lib/libunwind.so.8.0.1
b6c1d000 b6dcb000 r-xp /lib/libc-2.20-2014.11.so
b6dd3000 b6f16000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f18000 b6f70000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f71000 b6fa5000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa8000 b707c000 r-xp /usr/lib/libedje.so.1.13.0
b707f000 b70ab000 r-xp /usr/lib/libecore.so.1.13.0
b70bc000 b72e2000 r-xp /usr/lib/libevas.so.1.13.0
b730a000 b7322000 r-xp /lib/libpthread-2.20-2014.11.so
b7326000 b76a0000 r-xp /usr/lib/libelementary.so.1.13.0
b76c0000 b76c4000 r-xp /usr/lib/libsmack.so.1.0.0
b76c5000 b76ce000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76cf000 b76d2000 r-xp /usr/lib/libdlog.so.0.0.0
b76d3000 b76d8000 r-xp /usr/lib/libbundle.so.0.1.22
b76d9000 b76dc000 r-xp /lib/libdl-2.20-2014.11.so
b76de000 b7703000 r-xp /usr/lib/libaul.so.0.1.0
b7706000 b7708000 r-xp /usr/lib/libappsvc.so.0.1.0
b7709000 b770e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b770f000 b7716000 r-xp /usr/lib/libappcore-efl.so.1.1
b7718000 b771d000 r-xp /usr/lib/libsys-assert.so
b7720000 b7721000 r-xp [vdso]
b7721000 b7743000 r-xp /lib/ld-2.20-2014.11.so
b7745000 b774d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:5266)
Call Stack Count: 22
 0: view1_id_search_button_onclicked + 0x3d (0xb3511c4d) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xfc4d
 1: (0xb7145116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb637c319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6379d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71479e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb73f8404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb702bf39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7032a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb702cfdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb702d4cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb702d68f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb7092702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb708c055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70951b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb7095587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb74ee22d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7712dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb770bc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
18: app_run + 0x1cb (0xb351202b) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x1002b
19: main + 0x258 (0xb3513f78) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x11f78
20: (0xb7747148) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xb7747148
21: __libc_start_main + 0xde (0xb6c34e4e) [/lib/libc.so.6] + 0x17e4e
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
name(upgrade)
09-26 21:28:47.137+0900 D/PKGMGR  ( 3183): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.137+0900 D/PKGMGR  ( 5430): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.137+0900 D/PKGMGR  ( 3034): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.137+0900 D/QUICKPANEL( 3034): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.chattingapp key:install_percent val:100
09-26 21:28:47.147+0900 D/PKGMGR  ( 3056): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.147+0900 D/PKGMGR  ( 3030): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.147+0900 D/DATA_PROVIDER_MASTER( 3030): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.chattingapp] 100
09-26 21:28:47.147+0900 D/PKGMGR  ( 3136): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.147+0900 D/PKGMGR  ( 3027): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.147+0900 D/ESD     ( 3027): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30270002), pkg_type(tpk), pkgid(org.example.chattingapp), key(install_percent), val(100)
09-26 21:28:47.147+0900 D/PKGMGR  ( 3051): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.147+0900 D/PKGMGR  ( 3051): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
09-26 21:28:47.147+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.147+0900 W/cluster-home( 2984): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.chattingapp]
09-26 21:28:47.147+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[install_percent], value=[100]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29840003] pkg_type[tpk] package[org.example.chattingapp] key[install_percent] val[100] pmsg[(null)]
09-26 21:28:47.147+0900 D/PKGMGR  ( 3183): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/PKGMGR  ( 3034): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/QUICKPANEL( 3034): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.chattingapp key:end val:ok
09-26 21:28:47.147+0900 D/PKGMGR  ( 3136): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.chattingapp event_type=UPDATE event_state=COMPLETED progress=100 error=0
09-26 21:28:47.147+0900 D/PKGMGR  ( 5430): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/PKGMGR  ( 3056): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 W/cluster-home( 2984): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.chattingapp]
09-26 21:28:47.147+0900 D/cluster-home( 2984): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.chattingapp]
09-26 21:28:47.147+0900 D/PKGMGR  ( 2984): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[29840003] pkg_type[tpk] package[org.example.chattingapp] key[end] val[ok] pmsg[(null)]
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
09-26 21:28:47.147+0900 D/PKGMGR  ( 2879): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/AUL_AMD ( 2879): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.chattingapp), key(end), value(ok)
09-26 21:28:47.147+0900 W/AUL_AMD ( 2879): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(664) > [SECURE_LOG] op(update), value(ok)
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.chattingapp]
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.chattingapp]
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.chattingapp]
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.chattingapp]
09-26 21:28:47.147+0900 W/ISF_PANEL_EFL( 3136): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
09-26 21:28:47.147+0900 D/AUL_AMD ( 2879): amd_appinfo.c: __app_info_insert_handler(488) > [SECURE_LOG] appinfo file:org.example.chattingapp, type:rpm
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.chattingapp] Name[chattingapp] Icon[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png] enable[1] system[0]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.chattingapp]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.chattingapp
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.chattingapp], name[chattingapp], menuId[1], isPreload[0] isPreload[0]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
09-26 21:28:47.147+0900 E/cluster-home( 2984): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.chattingapp] Name[chattingapp] Icon[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png] enable[1] system[0]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [chattingapp]
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
09-26 21:28:47.147+0900 D/test-log( 2984): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png], New icon path[/opt/usr/apps/org.example.chattingapp/shared/res/chattingapp.png]!!!!!
09-26 21:28:47.147+0900 D/cluster-home( 2984): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
09-26 21:28:47.147+0900 D/PKGMGR  ( 3027): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.147+0900 D/ESD     ( 3027): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(30270002), pkg_type(tpk), pkgid(org.example.chattingapp), key(end), val(ok)
09-26 21:28:47.147+0900 D/ESD     ( 3027): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
09-26 21:28:47.157+0900 D/PKGMGR  ( 3051): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.157+0900 D/PKGMGR  ( 3051): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
09-26 21:28:47.157+0900 D/PKGMGR  ( 3030): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.chattingapp_1157529806], pkg_type=[tpk], pkgid=[org.example.chattingapp], key=[end], value=[ok]
09-26 21:28:47.157+0900 D/DATA_PROVIDER_MASTER( 3030): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.chattingapp] ok
09-26 21:28:47.157+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _invoke_package_change_event(916) > [SECURE_LOG] pkgname[org.example.chattingapp], event_type[1]
09-26 21:28:47.157+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _invoke_package_change_event(945) > [SECURE_LOG] _invoke_package_change_event returns [0]
09-26 21:28:47.157+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: service_thread_main(883) > [SECURE_LOG] (nil) PACKET_REQ_NOACK: Command: [package_install]
09-26 21:28:47.157+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _handler_package_install(579) > [SECURE_LOG] _handler_package_install
09-26 21:28:47.157+0900 D/DATA_PROVIDER_MASTER( 3030): notification_service.c: _handler_package_install(581) > [SECURE_LOG] package_name [org.example.chattingapp]
09-26 21:28:47.277+0900 D/rpm-installer( 5435): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
09-26 21:28:47.277+0900 D/rpm-installer( 5435): rpm-appcore-intf.c: main(259) > ------------------------------------------------
09-26 21:28:47.277+0900 D/rpm-installer( 5435): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
09-26 21:28:47.277+0900 D/rpm-installer( 5435): rpm-appcore-intf.c: main(261) > ------------------------------------------------
09-26 21:28:47.277+0900 D/PKGMGR_SERVER( 5432): pkgmgr-server.c: sighandler(387) > child exit [5435]
09-26 21:28:47.277+0900 E/PKGMGR_SERVER( 5432): pkgmgr-server.c: sighandler(402) > child NORMAL exit [5435]
09-26 21:28:48.997+0900 E/PKGMGR_SERVER( 5432): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
09-26 21:28:48.997+0900 E/PKGMGR_SERVER( 5432): pkgmgr-server.c: main(2265) > package manager server terminated.
09-26 21:28:49.337+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 0
09-26 21:28:49.337+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.chattingapp
09-26 21:28:49.337+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
09-26 21:28:49.337+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
09-26 21:28:49.337+0900 I/AUL     ( 2879): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
09-26 21:28:49.337+0900 D/AUL     ( 2879): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 5485, pid = 5487
09-26 21:28:49.337+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
09-26 21:28:49.337+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
09-26 21:28:49.337+0900 I/AUL     ( 2879): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
09-26 21:28:49.337+0900 E/AUL_AMD ( 2879): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
09-26 21:28:49.337+0900 W/AUL_AMD ( 2879): amd_launch.c: _start_app(2233) > caller pid : 5487
09-26 21:28:49.337+0900 E/AUL_AMD ( 2879): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
09-26 21:28:49.337+0900 W/AUL_AMD ( 2879): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.chattingapp) pkgid(org.example.chattingapp) attribute(600)
09-26 21:28:49.337+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2648) > process_pool: false
09-26 21:28:49.337+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
09-26 21:28:49.337+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.chattingapp
09-26 21:28:49.337+0900 W/AUL_AMD ( 2879): amd_launch.c: _start_app(2665) > pad pid(-5)
09-26 21:28:49.337+0900 D/AUL_AMD ( 2879): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
09-26 21:28:49.337+0900 D/AUL_AMD ( 2879): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
09-26 21:28:49.337+0900 D/AUL     ( 2879): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.chattingapp
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
09-26 21:28:49.337+0900 W/AUL_PAD ( 3028): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
09-26 21:28:49.337+0900 D/AUL     ( 3028): process_pool.c: __send_pkt_raw_data(219) > send(13) : 644 / 644
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 5266, bin path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:28:49.337+0900 W/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(265) > Check app launching
09-26 21:28:49.337+0900 D/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
09-26 21:28:49.337+0900 D/RESOURCED( 2954): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.chattingapp, pkgid = org.example.chattingapp, flags = 1536
09-26 21:28:49.337+0900 D/RESOURCED( 2954): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.chattingapp, pkgname = org.example.chattingapp, ref = 1
09-26 21:28:49.337+0900 E/RESOURCED( 2954): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
09-26 21:28:49.337+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
09-26 21:28:49.337+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 644, pkt->len: 636
09-26 21:28:49.337+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.chattingapp, launchpad type: 0
09-26 21:28:49.337+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
09-26 21:28:49.337+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.chattingapp
09-26 21:28:49.337+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.chattingapp
09-26 21:28:49.337+0900 D/AUL     ( 5266): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (5274) is sent.
09-26 21:28:49.337+0900 D/AUL     ( 5266): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 5274, signo: 10
09-26 21:28:49.347+0900 D/AUL     ( 5266): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.chattingapp / pkg_type : rpm / app_path : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.chattingapp/bin/chattingapp##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzQ4OTI5MjkvMzQyNDY4AA==##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1NDg3AA==##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.chattingapp/bin/chattingapp, real app argc: 8
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
09-26 21:28:49.347+0900 D/AUL_PAD ( 5266): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.chattingapp/bin/chattingapp)
09-26 21:28:49.347+0900 I/CAPI_APPFW_APPLICATION( 5266): app_main.c: ui_app_main(788) > app_efl_main
09-26 21:28:49.347+0900 D/LAUNCH  ( 5266): appcore-efl.c: appcore_efl_main(1692) > [chattingapp:Application:main:done]
09-26 21:28:49.347+0900 D/APP_CORE( 5266): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
09-26 21:28:49.347+0900 D/APP_CORE( 5266): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.chattingapp/res/locale
09-26 21:28:49.347+0900 D/APP_CORE( 5266): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
09-26 21:28:49.347+0900 D/APP_CORE( 5266): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
09-26 21:28:49.347+0900 D/AUL     ( 5266): app_sock.c: __create_server_sock(156) > pg path - already exists
09-26 21:28:49.347+0900 D/APP_CORE( 5266): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb426b520
09-26 21:28:49.347+0900 D/LAUNCH  ( 5266): appcore-efl.c: __before_loop(1136) > [chattingapp:Platform:appcore_init:done]
09-26 21:28:49.347+0900 I/CAPI_APPFW_APPLICATION( 5266): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
09-26 21:28:49.377+0900 E/E17     ( 2793): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
09-26 21:28:49.377+0900 D/IMMODULE( 5266): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
09-26 21:28:49.387+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:28:49.387+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:28:49.387+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:28:49.387+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:28:49.387+0900 E/E17     ( 2793): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
09-26 21:28:49.397+0900 W/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=5266
09-26 21:28:49.397+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:28:49.397+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:28:49.397+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 21:28:49.397+0900 E/EFL     ( 2793): eo<2793> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
09-26 21:28:49.397+0900 D/ISF_QUERY( 5266): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
09-26 21:28:49.397+0900 D/ISF_QUERY( 5266): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:28:49.397+0900 D/ISF_QUERY( 5266): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:28:49.397+0900 D/ISF_QUERY( 5266): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:28:49.397+0900 D/ISF_QUERY( 5266): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:28:49.397+0900 D/ISF_QUERY( 5266): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:28:49.397+0900 D/ISF_QUERY( 5266): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
09-26 21:28:49.407+0900 D/INDICATOR( 2958): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
09-26 21:28:49.407+0900 D/INDICATOR( 2958): util.c: util_signal_emit_by_win(116) > emission bg.opaque
09-26 21:28:49.407+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
09-26 21:28:49.407+0900 D/INDICATOR( 2958): main.c: _rotate_window(229) > Indicator angle is 0 degree
09-26 21:28:49.407+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
09-26 21:28:49.407+0900 D/INDICATOR( 2958): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
09-26 21:28:49.407+0900 D/INDICATOR( 2958): main.c: _rotate_window(252) > port :: hide more icon
09-26 21:28:49.407+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:28:49.407+0900 D/IMMODULE( 5266): scim_panel_client.cpp: open_connection(162) > 
09-26 21:28:49.407+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 21:28:49.407+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:28:49.407+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(515) > ppid:3028  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
09-26 21:28:49.407+0900 D/ISF_SOCKET( 5266): scim_socket.cpp: connect(524) > connect() succeeded
09-26 21:28:49.407+0900 D/IMMODULE( 5266): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
09-26 21:28:49.447+0900 D/AUL_PAD ( 3028): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
09-26 21:28:49.447+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 5266, appid: org.example.chattingapp
09-26 21:28:49.447+0900 D/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
09-26 21:28:49.447+0900 E/AUL     ( 2879): simple_util.c: __trm_app_info_send_socket(330) > access
09-26 21:28:49.447+0900 D/AUL_AMD ( 2879): amd_launch.c: _start_app(2700) > add app group info
09-26 21:28:49.447+0900 E/AUL     ( 2879): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
09-26 21:28:49.447+0900 D/AUL_AMD ( 2879): amd_status.c: _status_add_app_info_list(427) > pid(5266) appid(org.example.chattingapp) pkgid(org.example.chattingapp) comp(uiapp)
09-26 21:28:49.447+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 15
09-26 21:28:49.447+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:28:49.447+0900 D/PKGMGR_INFO( 2879): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
09-26 21:28:49.447+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.chattingapp, 5266
09-26 21:28:49.447+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.chattingapp with pkgname
09-26 21:28:49.447+0900 E/RESOURCED( 2954): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.chattingapp
09-26 21:28:49.447+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(888) > available memory = 306
09-26 21:28:49.447+0900 D/AUL_AMD ( 2879): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 5266 is org.example.chattingapp
09-26 21:28:49.447+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 5266 : 0
09-26 21:28:49.447+0900 D/AUL     ( 3056): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 32
09-26 21:28:49.447+0900 D/LAUNCH  ( 5266): appcore-efl.c: __before_loop(1154) > [chattingapp:Application:create:done]
09-26 21:28:49.477+0900 D/APP_CORE( 5266): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
09-26 21:28:49.487+0900 D/APP_CORE( 5266): appcore.c: __aul_handler(587) > [APP 5266]     AUL event: AUL_START
09-26 21:28:49.487+0900 I/APP_CORE( 5266): appcore-efl.c: __do_app(496) > [APP 5266] Event: RESET State: CREATED
09-26 21:28:49.487+0900 D/APP_CORE( 5266): appcore-efl.c: __do_app(527) > [APP 5266] RESET
09-26 21:28:49.487+0900 D/LAUNCH  ( 5266): appcore-efl.c: __do_app(529) > [chattingapp:Application:reset:start]
09-26 21:28:49.487+0900 D/APP_CORE( 5266): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
09-26 21:28:49.487+0900 D/APP_CORE( 5266): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 21:28:49.487+0900 I/CAPI_APPFW_APPLICATION( 5266): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
09-26 21:28:49.487+0900 D/AUL     ( 5266): service.c: __set_bundle(186) > __set_bundle
09-26 21:28:49.487+0900 D/LAUNCH  ( 5266): appcore-efl.c: __do_app(544) > [chattingapp:Application:reset:done]
09-26 21:28:49.487+0900 D/APP_CORE( 5266): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
09-26 21:28:49.487+0900 E/EFL     ( 5266): edje<5266> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:28:49.487+0900 E/EFL     ( 5266): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:28:49.497+0900 E/EFL     ( 5266): edje<5266> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:28:49.497+0900 E/EFL     ( 5266): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:28:49.497+0900 E/EFL     ( 5266): edje<5266> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
09-26 21:28:49.497+0900 E/EFL     ( 5266): By the power of Grayskull, your previous Embryo stack is now broken!
09-26 21:28:49.497+0900 W/APP_CORE( 5266): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
09-26 21:28:49.497+0900 D/APP_CORE( 5266): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
09-26 21:28:49.497+0900 D/APP_CORE( 5266): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
09-26 21:28:49.497+0900 D/AUL     ( 5266): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
09-26 21:28:49.497+0900 D/AUL_AMD ( 2879): amd_request.c: __request_handler(838) > __request_handler: 34
09-26 21:28:49.507+0900 D/IMMODULE( 5266): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb92b3540. set autocapital type : 2
09-26 21:28:49.507+0900 D/IMMODULE( 5266): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb92b3540. on demand : 0
09-26 21:28:49.507+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_in(245) > Enter
09-26 21:28:49.507+0900 D/ISE_DEFAULT( 3149): ise.cpp: ise_focus_in(824) > ic : 14920025 , 0 , g_ic : bd70025 , 0, g_focused_ic : 0 , 1
09-26 21:28:49.527+0900 D/IMMODULE( 5266): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 21:28:49.527+0900 D/IMMODULE( 5266): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb92b3540, cursor pos : 0
09-26 21:28:49.617+0900 D/APP_CORE( 5266): appcore.c: __prt_ltime(236) > [APP 5266] first idle after reset: 288 msec
09-26 21:28:49.677+0900 E/E17     ( 2793): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
09-26 21:28:49.677+0900 D/APP_CORE( 5266): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
09-26 21:28:49.677+0900 D/APP_CORE( 2984): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
09-26 21:28:49.677+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
09-26 21:28:49.677+0900 D/APP_CORE( 5266): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
09-26 21:28:49.677+0900 D/APP_CORE( 2984): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
09-26 21:28:49.677+0900 D/APP_CORE( 5266): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
09-26 21:28:49.677+0900 I/APP_CORE( 2984): appcore-efl.c: __do_app(496) > [APP 2984] Event: PAUSE State: RUNNING
09-26 21:28:49.677+0900 D/APP_CORE( 2984): appcore-efl.c: __do_app(565) > [APP 2984] PAUSE
09-26 21:28:49.677+0900 I/CAPI_APPFW_APPLICATION( 2984): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
09-26 21:28:49.677+0900 E/cluster-home( 2984): homescreen.cpp: OnPause(84) >  app pause
09-26 21:28:49.677+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
09-26 21:28:49.677+0900 D/cluster-view( 2984): homescreen-view-manager.cpp: AppPause(923) >  END
09-26 21:28:49.677+0900 D/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 21:28:49.677+0900 E/APP_CORE( 2984): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 21:28:49.677+0900 I/APP_CORE( 5266): appcore-efl.c: __do_app(496) > [APP 5266] Event: RESUME State: CREATED
09-26 21:28:49.677+0900 D/LAUNCH  ( 5266): appcore-efl.c: __do_app(597) > [chattingapp:Application:resume:start]
09-26 21:28:49.677+0900 D/APP_CORE( 5266): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
09-26 21:28:49.677+0900 D/APP_CORE( 5266): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
09-26 21:28:49.677+0900 D/APP_CORE( 5266): appcore-efl.c: __do_app(607) > [APP 5266] RESUME
09-26 21:28:49.677+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(2984) status(4)
09-26 21:28:49.677+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(2984) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
09-26 21:28:49.677+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
09-26 21:28:49.677+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2984, appid: org.tizen.homescreen, status: bg
09-26 21:28:49.677+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2891) > pid(5266) status(3)
09-26 21:28:49.677+0900 D/AUL_AMD ( 2879): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
09-26 21:28:49.677+0900 W/AUL_AMD ( 2879): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
09-26 21:28:49.677+0900 W/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
09-26 21:28:49.677+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(456) > pid(5266) status(3)
09-26 21:28:49.677+0900 D/AUL_AMD ( 2879): amd_status.c: _status_update_app_info_list(468) > pid(5266) appid(org.example.chattingapp) pkgid(org.example.chattingapp) status(3)
09-26 21:28:49.677+0900 D/AUL     ( 2879): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.chattingapp
09-26 21:28:49.677+0900 W/AUL     ( 2879): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 5266, appid: org.example.chattingapp, status: fg
09-26 21:28:49.677+0900 I/APP_CORE( 5266): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
09-26 21:28:49.677+0900 I/APP_CORE( 5266): appcore-efl.c: __do_app(614) > [APP 5266] Initial Launching, call the resume_cb
09-26 21:28:49.677+0900 I/CAPI_APPFW_APPLICATION( 5266): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
09-26 21:28:49.677+0900 D/LAUNCH  ( 5266): appcore-efl.c: __do_app(636) > [chattingapp:Application:resume:done]
09-26 21:28:49.677+0900 D/LAUNCH  ( 5266): appcore-efl.c: __do_app(638) > [chattingapp:Application:Launching:done]
09-26 21:28:49.677+0900 D/APP_CORE( 5266): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
09-26 21:28:49.677+0900 E/APP_CORE( 5266): appcore-efl.c: __trm_app_info_send_socket(242) > access
09-26 21:28:49.687+0900 D/RESOURCED( 2954): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 5266
09-26 21:28:49.687+0900 D/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 5266, proc_name: org.example.chattingapp, cg_name: foreground, oom_score_adj: 200
09-26 21:28:49.687+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 5266
09-26 21:28:49.687+0900 D/DATA_PROVIDER_MASTER( 3030): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2984 is paused
09-26 21:28:49.687+0900 D/DATA_PROVIDER_MASTER( 3030): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
09-26 21:28:49.757+0900 D/RESOURCED( 2954): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 5266, appname = org.example.chattingapp, pkgname = org.example.chattingapp
09-26 21:28:49.757+0900 D/RESOURCED( 2954): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 5266, appname = org.example.chattingapp
09-26 21:28:49.757+0900 D/RESOURCED( 2954): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 5266
09-26 21:28:49.757+0900 I/RESOURCED( 2954): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
09-26 21:28:49.757+0900 I/RESOURCED( 2954): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
09-26 21:28:49.857+0900 D/AUL_AMD ( 2879): amd_launch.c: __e17_status_handler(2910) > pid(5266) status(0)
09-26 21:28:50.447+0900 D/AUL_PAD ( 3028): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
09-26 21:28:50.447+0900 D/AUL_PAD ( 5495): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
09-26 21:28:50.457+0900 D/AUL_PAD ( 3028): sigchild.h: __send_app_launch_signal(131) > send launch signal done
09-26 21:28:50.457+0900 E/RESOURCED( 2954): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.341
09-26 21:28:50.907+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x202038 
09-26 21:28:50.907+0900 D/IMMODULE( 5266): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb92b3540
09-26 21:28:50.907+0900 D/IMMODULE( 5266): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
09-26 21:28:50.947+0900 D/AUL_AMD ( 2879): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.chattingapp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
09-26 21:28:50.947+0900 D/RUA     ( 2879): rua.c: rua_add_history(179) > rua_add_history start
09-26 21:28:50.947+0900 D/RUA     ( 2879): rua.c: rua_add_history(247) > rua_add_history ok
09-26 21:28:51.147+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x202038 
09-26 21:28:51.477+0900 D/AUL_PAD ( 5495): launchpad_loader.c: main(588) > sleeping 1 sec...
09-26 21:28:51.477+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(52) > max_cmdline_size = 1053
09-26 21:28:51.477+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b977d760
09-26 21:28:51.477+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(69) > get pre-initialization function
09-26 21:28:51.477+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(73) > get shutdown function
09-26 21:28:51.477+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b977da40
09-26 21:28:51.487+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b977f640
09-26 21:28:51.487+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(69) > get pre-initialization function
09-26 21:28:51.487+0900 D/AUL_PAD ( 5495): preload.h: __preload_init(73) > get shutdown function
09-26 21:28:51.487+0900 D/AUL_PAD ( 5495): preexec.h: __preexec_init(76) > preexec start
09-26 21:28:51.487+0900 D/AUL_PAD ( 5495): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
09-26 21:28:51.487+0900 D/AUL     ( 5495): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
09-26 21:28:51.487+0900 D/AUL     ( 5495): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
09-26 21:28:51.487+0900 D/AUL     ( 5495): process_pool.c: __connect_to_launchpad(132) > send(5495) : 4
09-26 21:28:51.487+0900 D/AUL     ( 5495): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
09-26 21:28:51.487+0900 D/AUL_PAD ( 3028): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 5495
09-26 21:28:51.557+0900 D/AUL_PAD ( 5495): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
09-26 21:28:51.567+0900 D/AUL_PAD ( 5495): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
09-26 21:28:51.567+0900 D/AUL_PAD ( 5495): launchpad_loader.c: main(693) > [candidate] ecore handler add
09-26 21:28:51.567+0900 D/AUL_PAD ( 5495): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
09-26 21:28:51.757+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x202038 
09-26 21:28:52.407+0900 D/IMMODULE( 5266): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb92b3540
09-26 21:28:52.417+0900 D/IMMODULE( 5266): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
09-26 21:28:52.417+0900 D/IMMODULE( 5266): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb92b3540
09-26 21:28:52.417+0900 D/PROCESSMGR( 2793): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x202038 
09-26 21:28:52.417+0900 D/ISE_DEFAULT( 3149): ise.cpp: on_focus_out(251) > Enter
09-26 21:28:52.677+0900 W/CRASH_MANAGER( 5498): worker.c: worker_job(1204) > 1105266636861147489293
