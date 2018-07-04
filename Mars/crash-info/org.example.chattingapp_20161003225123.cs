S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160504.2021
Build-Date: 2016.05.04 20:21:45

Crash Information
Process Name: chattingapp
PID: 7216
Date: 2016-10-03 22:51:23+0900
Executable File Path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8d36c50, esi = 0xbfed6d90
ebp = 0xbfed6db8, esp = 0xbfed6d8c
eax = 0x00000000, ebx = 0xb3556344
ecx = 0x00000000, edx = 0xb3553c61
eip = 0xb6d8ec08

Memory Information
MemTotal:      123 KB
MemFree:        27 KB
Buffers:         8 KB
Cached:     164756 KB
VmPeak:     118616 KB
VmSize:     118616 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24548 KB
VmRSS:       24548 KB
VmData:      52628 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33544 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 7216 TID = 7216
7216 7218 7219 7223 7224 7227 

Maps Information
b1b2f000 b1b36000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1b78000 b1b90000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1b91000 b1b98000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b239a000 b23a4000 r-xp /usr/lib/libfeedback.so.0.1.4
b23aa000 b23b6000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b23b7000 b23d8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b23dd000 b23de000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b23df000 b23e4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b23e5000 b23e6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b23e7000 b23f3000 r-xp /usr/lib/libdrm.so.2.4.0
b23f4000 b23fe000 r-xp /usr/lib/libtbm.so.1.0.0
b2d00000 b2d02000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d03000 b2d05000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d06000 b2d09000 r-xp /usr/lib/libdri2.so.0.0.0
b2d0a000 b2d0b000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2d0c000 b2d21000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d22000 b2d34000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3536000 b353f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3540000 b3556000 r-xp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
b365e000 b3664000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3665000 b37a9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bf000 b37c0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b37c1000 b37c2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b37c3000 b37c6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b37c7000 b37ca000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b37cb000 b3804000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4207000 b4212000 r-xp /lib/libnss_files-2.20-2014.11.so
b4214000 b421f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4221000 b4238000 r-xp /lib/libnsl-2.20-2014.11.so
b423c000 b4244000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4246000 b426a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b426b000 b426c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b426d000 b4270000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4271000 b4278000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4279000 b4283000 r-xp /usr/lib/libsensord-share.so
b4284000 b42a0000 r-xp /usr/lib/libsensor.so.1.2.0
b42a2000 b42ab000 r-xp /usr/lib/libappcore-common.so.1.1
b42ae000 b42b0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42c5000 b42c7000 r-xp /usr/lib/libXau.so.6.0.0
b42c8000 b42ea000 r-xp /usr/lib/libxcb.so.1.1.0
b42ec000 b42f5000 r-xp /lib/libcrypt-2.20-2014.11.so
b431e000 b4320000 r-xp /usr/lib/libiri.so
b4321000 b4347000 r-xp /lib/libexpat.so.1.5.2
b4349000 b43b4000 r-xp /usr/lib/libssl.so.1.0.0
b43ba000 b43c6000 r-xp /usr/lib/libethumb.so.1.13.0
b43c7000 b43cb000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43cc000 b461d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b98000 b5ba8000 r-xp /usr/lib/libXi.so.6.1.0
b5ba9000 b5bab000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bac000 b5bb2000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb3000 b5bbd000 r-xp /usr/lib/libXrender.so.1.3.0
b5bbe000 b5bc7000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bc9000 b5bcb000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bcc000 b5bd1000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd2000 b5be4000 r-xp /usr/lib/libXext.so.6.4.0
b5be5000 b5be7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5be8000 b5bea000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bec000 b5d2e000 r-xp /usr/lib/libX11.so.6.3.0
b5d32000 b5d3c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d3d000 b5d53000 r-xp /usr/lib/libudev.so.1.6.0
b5d56000 b5d5a000 r-xp /lib/libattr.so.1.1.0
b5d5b000 b5d8a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d8c000 b5d92000 r-xp /usr/lib/libffi.so.6.0.2
b5d93000 b5db6000 r-xp /lib/libz.so.1.2.8
b5db7000 b5dba000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dbb000 b5f17000 r-xp /usr/lib/libxml2.so.2.9.2
b5f1d000 b6004000 r-xp /usr/lib/libstdc++.so.6.0.20
b6011000 b6014000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6015000 b6037000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6038000 b604c000 r-xp /lib/libresolv-2.20-2014.11.so
b6050000 b6074000 r-xp /usr/lib/liblzma.so.5.0.3
b6075000 b6077000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6079000 b6083000 r-xp /usr/lib/libembryo.so.1.13.0
b6084000 b60ad000 r-xp /usr/lib/libpng12.so.0.50.0
b60ae000 b60f7000 r-xp /usr/lib/libjpeg.so.8.0.2
b6108000 b610f000 r-xp /lib/librt-2.20-2014.11.so
b6111000 b6130000 r-xp /usr/lib/libector.so.1.13.0
b6133000 b6160000 r-xp /usr/lib/liblua-5.1.so
b6161000 b61f1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61f5000 b6233000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6234000 b624a000 r-xp /usr/lib/libfribidi.so.0.3.1
b624b000 b62a4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62a7000 b62f2000 r-xp /lib/libm-2.20-2014.11.so
b62f4000 b6306000 r-xp /usr/lib/libeio.so.1.13.0
b6307000 b630a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b630b000 b6311000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6312000 b6335000 r-xp /usr/lib/libefreet.so.1.13.0
b6338000 b6363000 r-xp /usr/lib/libeldbus.so.1.13.0
b6364000 b6398000 r-xp /usr/lib/libecore_con.so.1.13.0
b639a000 b63a3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a4000 b63ad000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63ae000 b63c1000 r-xp /usr/lib/libeo.so.1.13.0
b63c3000 b63d6000 r-xp /usr/lib/libecore_input.so.1.13.0
b63d7000 b63de000 r-xp /usr/lib/libecore_file.so.1.13.0
b63df000 b6402000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6403000 b642f000 r-xp /usr/lib/libeet.so.1.13.0
b6438000 b64a3000 r-xp /usr/lib/libeina.so.1.13.0
b64a6000 b64bd000 r-xp /usr/lib/libefl.so.1.13.0
b64bf000 b6626000 r-xp /usr/lib/libicuuc.so.51.1
b6634000 b6840000 r-xp /usr/lib/libicui18n.so.51.1
b6848000 b6897000 r-xp /usr/lib/libecore_x.so.1.13.0
b6899000 b68b3000 r-xp /lib/libgcc_s-4.9.so.1
b68b5000 b68b9000 r-xp /lib/libcap.so.2.21
b68ba000 b6900000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6901000 b6908000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b690a000 b695c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b695e000 b6ae9000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aee000 b6bbc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bbf000 b6bc3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc4000 b6bd3000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd4000 b6bd7000 r-xp /usr/lib/libvasum.so.0.3.1
b6bd8000 b6bdb000 r-xp /usr/lib/libttrace.so.1.1
b6bdd000 b6be1000 r-xp /usr/lib/libiniparser.so.0
b6be2000 b6c12000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c13000 b6c1c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c1d000 b6c42000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c43000 b6c53000 r-xp /usr/lib/libunwind.so.8.0.1
b6c5d000 b6e0b000 r-xp /lib/libc-2.20-2014.11.so
b6e13000 b6f56000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f58000 b6fb0000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb1000 b6fe5000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fe8000 b70bc000 r-xp /usr/lib/libedje.so.1.13.0
b70bf000 b70eb000 r-xp /usr/lib/libecore.so.1.13.0
b70fc000 b7322000 r-xp /usr/lib/libevas.so.1.13.0
b734a000 b7362000 r-xp /lib/libpthread-2.20-2014.11.so
b7366000 b76e0000 r-xp /usr/lib/libelementary.so.1.13.0
b7700000 b7704000 r-xp /usr/lib/libsmack.so.1.0.0
b7705000 b770e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b770f000 b7712000 r-xp /usr/lib/libdlog.so.0.0.0
b7713000 b7718000 r-xp /usr/lib/libbundle.so.0.1.22
b7719000 b771c000 r-xp /lib/libdl-2.20-2014.11.so
b771e000 b7743000 r-xp /usr/lib/libaul.so.0.1.0
b7746000 b7748000 r-xp /usr/lib/libappsvc.so.0.1.0
b7749000 b774e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b774f000 b7756000 r-xp /usr/lib/libappcore-efl.so.1.1
b7758000 b775d000 r-xp /usr/lib/libsys-assert.so
b7760000 b7761000 r-xp [vdso]
b7761000 b7783000 r-xp /lib/ld-2.20-2014.11.so
b7785000 b778d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7216)
Call Stack Count: 26
 0: (0xb6d8ec08) [/lib/libc.so.6] + 0x131c08
 1: add_view_context + 0x2d (0xb355200d) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x1200d
 2: uib_view_add_friend_view_create + 0xd2 (0xb3544f92) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x4f92
 3: uib_util_push_view + 0x228 (0xb3551978) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x11978
 4: chatting_room_view_add_friend_button_onclicked + 0x49 (0xb3552669) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x12669
 5: (0xb7185116) [/usr/lib/libevas.so.1] + 0x89116
 6: (0xb63bc319) [/usr/lib/libeo.so.1] + 0xe319
 7: eo_event_callback_call + 0xb3 (0xb63b9d63) [/usr/lib/libeo.so.1] + 0xbd63
 8: evas_object_smart_callback_call + 0x75 (0xb71879e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 9: (0xb7438404) [/usr/lib/libelementary.so.1] + 0xd2404
10: (0xb706bf39) [/usr/lib/libedje.so.1] + 0x83f39
11: (0xb7072a11) [/usr/lib/libedje.so.1] + 0x8aa11
12: (0xb706cfdc) [/usr/lib/libedje.so.1] + 0x84fdc
13: (0xb706d4cb) [/usr/lib/libedje.so.1] + 0x854cb
14: (0xb706d68f) [/usr/lib/libedje.so.1] + 0x8568f
15: (0xb70d2702) [/usr/lib/libecore.so.1] + 0x13702
16: (0xb70cc055) [/usr/lib/libecore.so.1] + 0xd055
17: (0xb70d51b9) [/usr/lib/libecore.so.1] + 0x161b9
18: ecore_main_loop_begin + 0x57 (0xb70d5587) [/usr/lib/libecore.so.1] + 0x16587
19: elm_run + 0x2d (0xb752e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
20: appcore_efl_main + 0x4de (0xb7752dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
21: ui_app_main + 0x140 (0xb774bc40) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c40
22: app_run + 0x1cb (0xb3542c5b) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x2c5b
23: main + 0x23a (0xb354310a) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0x310a
24: (0xb7787148) [/opt/usr/apps/org.example.chattingapp/bin/chattingapp] + 0xb7787148
25: __libc_start_main + 0xde (0xb6c74e4e) [/lib/libc.so.6] + 0x17e4e
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
(229) > Indicator angle is 0 degree
10-03 22:51:17.061+0900 D/INDICATOR( 2898): box.c: box_get_right_item_count(242) > system cnt : 1, minictrl cnt : 0, noti cnt : 0
10-03 22:51:17.061+0900 D/INDICATOR( 2898): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
10-03 22:51:17.061+0900 D/INDICATOR( 2898): main.c: _rotate_window(252) > port :: hide more icon
10-03 22:51:17.091+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-03 22:51:17.091+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-03 22:51:17.091+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-03 22:51:17.091+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-03 22:51:17.091+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-03 22:51:17.091+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-03 22:51:17.091+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-03 22:51:17.091+0900 I/AUL_PAD ( 2959): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 7200 pgid = 7200
10-03 22:51:17.091+0900 I/AUL_PAD ( 2959): sigchild.h: __sigchild_action(142) > dead_pid(7200)
10-03 22:51:17.101+0900 D/AUL_PAD ( 2959): sigchild.h: __send_app_dead_signal(90) > send dead signal done
10-03 22:51:17.101+0900 I/AUL_PAD ( 2959): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
10-03 22:51:17.101+0900 I/AUL_PAD ( 2959): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
10-03 22:51:17.101+0900 E/AUL_PAD ( 2959): launchpad.c: main(688) > error reading sigchld info
10-03 22:51:17.101+0900 I/ESD     ( 2958): esd_main.c: __esd_app_dead_handler(1771) > pid: 7200
10-03 22:51:17.101+0900 W/AUL_AMD ( 2791): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 7200
10-03 22:51:17.101+0900 W/AUL_AMD ( 2791): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 7200
10-03 22:51:17.101+0900 D/AUL_AMD ( 2791): amd_key.c: _unregister_key_event(179) > ===key stack===
10-03 22:51:17.101+0900 E/AUL_AMD ( 2791): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
10-03 22:51:17.101+0900 D/AUL_AMD ( 2791): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.task-mgr)
10-03 22:51:17.101+0900 D/AUL     ( 2791): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-03 22:51:17.101+0900 E/AUL     ( 2791): simple_util.c: __trm_app_info_send_socket(330) > access
10-03 22:51:17.101+0900 D/STARTER ( 2893): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 7200 is termianted
10-03 22:51:17.101+0900 D/STARTER ( 2893): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
10-03 22:51:17.101+0900 E/RESOURCED( 2895): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.592
10-03 22:51:17.101+0900 D/RESOURCED( 2895): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 7200
10-03 22:51:17.101+0900 D/RESOURCED( 2895): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.task-mgr, pkgname = org.tizen.task-mgr, ref = 0
10-03 22:51:17.171+0900 E/EFL     ( 2828): eo<2828> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-03 22:51:17.181+0900 D/AUL_AMD ( 2791): amd_request.c: __request_handler(838) > __request_handler: 15
10-03 22:51:17.181+0900 D/PKGMGR_INFO( 2791): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-03 22:51:17.181+0900 D/PKGMGR_INFO( 2791): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
10-03 22:51:17.181+0900 D/AUL_AMD ( 2791): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2913 is org.tizen.homescreen
10-03 22:51:17.181+0900 D/AUL_AMD ( 2791): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2913 : 0
10-03 22:51:17.181+0900 D/AUL     ( 2990): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
10-03 22:51:17.751+0900 D/test-log( 2913): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
10-03 22:51:17.751+0900 D/test-log( 2913): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
10-03 22:51:17.831+0900 D/test-log( 2913): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
10-03 22:51:17.831+0900 D/test-log( 2913): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
10-03 22:51:17.831+0900 D/test-log( 2913): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
10-03 22:51:17.831+0900 D/test-log( 2913): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
10-03 22:51:17.831+0900 D/test-log( 2913): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[463.00][219.00] to[463.00][219.00]!
10-03 22:51:17.831+0900 D/cluster-view( 2913): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
10-03 22:51:17.831+0900 D/cluster-home( 2913): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [38]MenuBox clicked
10-03 22:51:17.831+0900 D/cluster-home( 2913): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
10-03 22:51:17.831+0900 D/AUL     ( 2913): service.c: __set_bundle(186) > __set_bundle
10-03 22:51:17.831+0900 D/AUL     ( 2913): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
10-03 22:51:17.831+0900 D/AUL     ( 2913): service.c: __set_bundle(186) > __set_bundle
10-03 22:51:17.831+0900 D/AUL     ( 2913): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.chattingapp - no result
10-03 22:51:17.831+0900 D/AUL     ( 2913): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.chattingapp
10-03 22:51:17.831+0900 D/AUL     ( 2913): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
10-03 22:51:17.831+0900 D/AUL_AMD ( 2791): amd_request.c: __request_handler(838) > __request_handler: 0
10-03 22:51:17.831+0900 D/AUL_AMD ( 2791): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.chattingapp
10-03 22:51:17.831+0900 W/AUL_AMD ( 2791): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
10-03 22:51:17.831+0900 W/AUL_AMD ( 2791): amd_launch.c: _start_app(2233) > caller pid : 2913
10-03 22:51:17.831+0900 D/AUL_AMD ( 2791): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
10-03 22:51:17.831+0900 D/AUL_AMD ( 2791): amd_key.c: _key_grab(243) > _key_grab, win : a00002
10-03 22:51:17.841+0900 D/AUL_AMD ( 2791): amd_launch.c: _start_app(2448) > back key grab
10-03 22:51:17.841+0900 W/AUL_AMD ( 2791): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.chattingapp) pkgid(org.example.chattingapp) attribute(600)
10-03 22:51:17.841+0900 D/PROCESSMGR( 2828): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x60004c 
10-03 22:51:17.841+0900 D/RESOURCED( 2895): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.chattingapp, pkgid = org.example.chattingapp, flags = 1536
10-03 22:51:17.841+0900 D/RESOURCED( 2895): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.chattingapp, pkgname = org.example.chattingapp, ref = 1
10-03 22:51:17.841+0900 E/RESOURCED( 2895): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-03 22:51:17.841+0900 D/AUL_AMD ( 2791): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
10-03 22:51:17.841+0900 D/AUL_AMD ( 2791): amd_launch.c: _start_app(2648) > process_pool: false
10-03 22:51:17.841+0900 D/AUL_AMD ( 2791): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
10-03 22:51:17.841+0900 D/AUL_AMD ( 2791): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.chattingapp
10-03 22:51:17.841+0900 W/AUL_AMD ( 2791): amd_launch.c: _start_app(2665) > pad pid(-5)
10-03 22:51:17.841+0900 D/AUL_AMD ( 2791): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
10-03 22:51:17.841+0900 D/AUL_AMD ( 2791): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
10-03 22:51:17.841+0900 D/AUL     ( 2791): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.chattingapp
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
10-03 22:51:17.841+0900 W/AUL_PAD ( 2959): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
10-03 22:51:17.841+0900 D/AUL     ( 2959): process_pool.c: __send_pkt_raw_data(219) > send(13) : 912 / 912
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 7216, bin path: /opt/usr/apps/org.example.chattingapp/bin/chattingapp
10-03 22:51:17.841+0900 W/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(265) > Check app launching
10-03 22:51:17.841+0900 D/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
10-03 22:51:17.841+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
10-03 22:51:17.841+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 912, pkt->len: 904
10-03 22:51:17.841+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.chattingapp, launchpad type: 0
10-03 22:51:17.841+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
10-03 22:51:17.841+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.chattingapp
10-03 22:51:17.841+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.chattingapp
10-03 22:51:17.841+0900 D/AUL     ( 7216): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7218) is sent.
10-03 22:51:17.841+0900 D/AUL     ( 7216): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7218, signo: 10
10-03 22:51:17.841+0900 D/AUL     ( 7216): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
10-03 22:51:17.841+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.chattingapp / pkg_type : rpm / app_path : /opt/usr/apps/org.example.chattingapp/bin/chattingapp
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.chattingapp/bin/chattingapp##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : PQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AGAAAAG9yZy5leGFtcGxlLmNoYXR0aW5nYXBwAA==##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0NzU1MDI2NzcvODQ3MDA4AA==##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTEzAA==##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.chattingapp/bin/chattingapp, real app argc: 14
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
10-03 22:51:17.851+0900 D/AUL_PAD ( 7216): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.chattingapp/bin/chattingapp)
10-03 22:51:17.851+0900 I/CAPI_APPFW_APPLICATION( 7216): app_main.c: ui_app_main(788) > app_efl_main
10-03 22:51:17.851+0900 D/LAUNCH  ( 7216): appcore-efl.c: appcore_efl_main(1692) > [chattingapp:Application:main:done]
10-03 22:51:17.851+0900 D/APP_CORE( 7216): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
10-03 22:51:17.851+0900 D/APP_CORE( 7216): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.chattingapp/res/locale
10-03 22:51:17.851+0900 D/APP_CORE( 7216): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
10-03 22:51:17.861+0900 D/APP_CORE( 7216): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
10-03 22:51:17.861+0900 D/AUL     ( 7216): app_sock.c: __create_server_sock(156) > pg path - already exists
10-03 22:51:17.861+0900 D/APP_CORE( 7216): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42ab520
10-03 22:51:17.861+0900 D/LAUNCH  ( 7216): appcore-efl.c: __before_loop(1136) > [chattingapp:Platform:appcore_init:done]
10-03 22:51:17.861+0900 I/CAPI_APPFW_APPLICATION( 7216): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
10-03 22:51:17.911+0900 D/IMMODULE( 7216): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
10-03 22:51:17.911+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(515) > ppid:2959  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
10-03 22:51:17.911+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(524) > connect() succeeded
10-03 22:51:17.911+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(515) > ppid:2959  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
10-03 22:51:17.911+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(524) > connect() succeeded
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(515) > ppid:2959  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(524) > connect() succeeded
10-03 22:51:17.921+0900 D/ISF_QUERY( 7216): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
10-03 22:51:17.921+0900 D/ISF_QUERY( 7216): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-03 22:51:17.921+0900 D/ISF_QUERY( 7216): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-03 22:51:17.921+0900 D/ISF_QUERY( 7216): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-03 22:51:17.921+0900 D/ISF_QUERY( 7216): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-03 22:51:17.921+0900 D/ISF_QUERY( 7216): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-03 22:51:17.921+0900 D/ISF_QUERY( 7216): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(515) > ppid:2959  trying connect() to local:/tmp/scim-socket-frontend, chattingapp
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(524) > connect() succeeded
10-03 22:51:17.921+0900 D/IMMODULE( 7216): scim_panel_client.cpp: open_connection(162) > 
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(515) > ppid:2959  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(524) > connect() succeeded
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(515) > ppid:2959  trying connect() to local:/tmp/scim-panel-socket:0, chattingapp
10-03 22:51:17.921+0900 D/ISF_SOCKET( 7216): scim_socket.cpp: connect(524) > connect() succeeded
10-03 22:51:17.921+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
10-03 22:51:17.961+0900 D/AUL_PAD ( 2959): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
10-03 22:51:17.961+0900 W/AUL     ( 2791): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7216, appid: org.example.chattingapp
10-03 22:51:17.961+0900 D/AUL     ( 2791): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
10-03 22:51:17.961+0900 E/AUL     ( 2791): simple_util.c: __trm_app_info_send_socket(330) > access
10-03 22:51:17.961+0900 D/AUL_AMD ( 2791): amd_launch.c: _start_app(2700) > add app group info
10-03 22:51:17.961+0900 E/AUL     ( 2791): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
10-03 22:51:17.961+0900 D/AUL_AMD ( 2791): amd_status.c: _status_add_app_info_list(427) > pid(7216) appid(org.example.chattingapp) pkgid(org.example.chattingapp) comp(uiapp)
10-03 22:51:17.961+0900 D/RESOURCED( 2895): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.chattingapp, 7216
10-03 22:51:17.961+0900 D/AUL     ( 2913): launch.c: app_request_to_launchpad(425) > launch request result : 7216
10-03 22:51:17.961+0900 D/RESOURCED( 2895): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.chattingapp with pkgname
10-03 22:51:17.961+0900 E/RESOURCED( 2895): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.chattingapp
10-03 22:51:17.961+0900 E/cluster-home( 2913): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.chattingapp]
10-03 22:51:17.961+0900 D/test-log( 2913): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
10-03 22:51:17.961+0900 D/RESOURCED( 2895): proc-main.c: resourced_proc_status_change(888) > available memory = 315
10-03 22:51:17.961+0900 E/E17     ( 2828): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
10-03 22:51:17.971+0900 E/E17     ( 2828): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
10-03 22:51:17.981+0900 W/PROCESSMGR( 2828): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7216
10-03 22:51:18.011+0900 E/EFL     ( 2828): eo<2828> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-03 22:51:18.011+0900 E/EFL     ( 2828): eo<2828> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
10-03 22:51:18.011+0900 D/AUL_AMD ( 2791): amd_request.c: __request_handler(838) > __request_handler: 15
10-03 22:51:18.011+0900 D/PKGMGR_INFO( 2791): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
10-03 22:51:18.011+0900 D/PKGMGR_INFO( 2791): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.chattingapp/bin/chattingapp' and package_app_info.app_disable IN ('false','False')
10-03 22:51:18.011+0900 D/LAUNCH  ( 7216): appcore-efl.c: __before_loop(1154) > [chattingapp:Application:create:done]
10-03 22:51:18.011+0900 D/AUL_AMD ( 2791): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7216 is org.example.chattingapp
10-03 22:51:18.011+0900 D/AUL_AMD ( 2791): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7216 : 0
10-03 22:51:18.011+0900 D/AUL     ( 2990): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 32
10-03 22:51:18.011+0900 D/INDICATOR( 2898): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
10-03 22:51:18.011+0900 D/INDICATOR( 2898): util.c: util_signal_emit_by_win(116) > emission bg.opaque
10-03 22:51:18.011+0900 D/INDICATOR( 2898): main.c: _rotate_window(229) > Indicator angle is 0 degree
10-03 22:51:18.011+0900 D/INDICATOR( 2898): box.c: box_get_right_item_count(242) > system cnt : 1, minictrl cnt : 0, noti cnt : 0
10-03 22:51:18.011+0900 D/INDICATOR( 2898): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 1
10-03 22:51:18.011+0900 D/INDICATOR( 2898): main.c: _rotate_window(252) > port :: hide more icon
10-03 22:51:18.031+0900 D/APP_CORE( 7216): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
10-03 22:51:18.041+0900 D/APP_CORE( 7216): appcore.c: __aul_handler(587) > [APP 7216]     AUL event: AUL_START
10-03 22:51:18.041+0900 I/APP_CORE( 7216): appcore-efl.c: __do_app(496) > [APP 7216] Event: RESET State: CREATED
10-03 22:51:18.041+0900 D/APP_CORE( 7216): appcore-efl.c: __do_app(527) > [APP 7216] RESET
10-03 22:51:18.041+0900 D/LAUNCH  ( 7216): appcore-efl.c: __do_app(529) > [chattingapp:Application:reset:start]
10-03 22:51:18.041+0900 D/APP_CORE( 7216): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
10-03 22:51:18.041+0900 D/APP_CORE( 7216): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-03 22:51:18.041+0900 I/CAPI_APPFW_APPLICATION( 7216): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
10-03 22:51:18.041+0900 D/LAUNCH  ( 7216): appcore-efl.c: __do_app(544) > [chattingapp:Application:reset:done]
10-03 22:51:18.041+0900 D/APP_CORE( 7216): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
10-03 22:51:18.041+0900 E/EFL     ( 7216): edje<7216> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-03 22:51:18.041+0900 E/EFL     ( 7216): By the power of Grayskull, your previous Embryo stack is now broken!
10-03 22:51:18.041+0900 E/EFL     ( 7216): edje<7216> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-03 22:51:18.041+0900 E/EFL     ( 7216): By the power of Grayskull, your previous Embryo stack is now broken!
10-03 22:51:18.041+0900 E/EFL     ( 7216): edje<7216> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
10-03 22:51:18.041+0900 E/EFL     ( 7216): By the power of Grayskull, your previous Embryo stack is now broken!
10-03 22:51:18.051+0900 W/APP_CORE( 7216): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
10-03 22:51:18.051+0900 D/APP_CORE( 7216): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
10-03 22:51:18.051+0900 D/APP_CORE( 7216): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
10-03 22:51:18.051+0900 D/AUL     ( 7216): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
10-03 22:51:18.051+0900 D/AUL_AMD ( 2791): amd_request.c: __request_handler(838) > __request_handler: 34
10-03 22:51:18.051+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8c01088. set autocapital type : 2
10-03 22:51:18.051+0900 D/ISE_DEFAULT( 3072): ise.cpp: on_focus_in(245) > Enter
10-03 22:51:18.061+0900 D/ISE_DEFAULT( 3072): ise.cpp: ise_focus_in(824) > ic : 1c300023 , 0 , g_ic : e7e0023 , 0, g_focused_ic : 0 , 1
10-03 22:51:18.061+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8c01088. on demand : 0
10-03 22:51:18.061+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-03 22:51:18.061+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c01088, cursor pos : 0
10-03 22:51:18.241+0900 D/APP_CORE( 7216): appcore.c: __prt_ltime(236) > [APP 7216] first idle after reset: 413 msec
10-03 22:51:18.271+0900 E/E17     ( 2828): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
10-03 22:51:18.271+0900 D/APP_CORE( 2913): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
10-03 22:51:18.271+0900 D/APP_CORE( 2913): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
10-03 22:51:18.271+0900 D/APP_CORE( 2913): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
10-03 22:51:18.271+0900 I/APP_CORE( 2913): appcore-efl.c: __do_app(496) > [APP 2913] Event: PAUSE State: RUNNING
10-03 22:51:18.271+0900 D/APP_CORE( 2913): appcore-efl.c: __do_app(565) > [APP 2913] PAUSE
10-03 22:51:18.271+0900 I/CAPI_APPFW_APPLICATION( 2913): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
10-03 22:51:18.271+0900 E/cluster-home( 2913): homescreen.cpp: OnPause(84) >  app pause
10-03 22:51:18.271+0900 D/cluster-view( 2913): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
10-03 22:51:18.271+0900 D/cluster-view( 2913): homescreen-view-manager.cpp: AppPause(923) >  END
10-03 22:51:18.271+0900 D/APP_CORE( 2913): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-03 22:51:18.271+0900 E/APP_CORE( 2913): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-03 22:51:18.271+0900 D/APP_CORE( 7216): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
10-03 22:51:18.271+0900 D/APP_CORE( 7216): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
10-03 22:51:18.271+0900 D/APP_CORE( 7216): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
10-03 22:51:18.271+0900 I/APP_CORE( 7216): appcore-efl.c: __do_app(496) > [APP 7216] Event: RESUME State: CREATED
10-03 22:51:18.271+0900 D/LAUNCH  ( 7216): appcore-efl.c: __do_app(597) > [chattingapp:Application:resume:start]
10-03 22:51:18.271+0900 D/APP_CORE( 7216): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
10-03 22:51:18.271+0900 D/APP_CORE( 7216): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
10-03 22:51:18.271+0900 D/APP_CORE( 7216): appcore-efl.c: __do_app(607) > [APP 7216] RESUME
10-03 22:51:18.271+0900 D/AUL_AMD ( 2791): amd_status.c: _status_update_app_info_list(456) > pid(2913) status(4)
10-03 22:51:18.271+0900 D/AUL_AMD ( 2791): amd_status.c: _status_update_app_info_list(468) > pid(2913) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
10-03 22:51:18.271+0900 D/AUL     ( 2791): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
10-03 22:51:18.271+0900 W/AUL     ( 2791): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2913, appid: org.tizen.homescreen, status: bg
10-03 22:51:18.271+0900 I/APP_CORE( 7216): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
10-03 22:51:18.271+0900 I/APP_CORE( 7216): appcore-efl.c: __do_app(614) > [APP 7216] Initial Launching, call the resume_cb
10-03 22:51:18.271+0900 I/CAPI_APPFW_APPLICATION( 7216): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
10-03 22:51:18.271+0900 D/LAUNCH  ( 7216): appcore-efl.c: __do_app(636) > [chattingapp:Application:resume:done]
10-03 22:51:18.271+0900 D/LAUNCH  ( 7216): appcore-efl.c: __do_app(638) > [chattingapp:Application:Launching:done]
10-03 22:51:18.271+0900 D/APP_CORE( 7216): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
10-03 22:51:18.271+0900 E/APP_CORE( 7216): appcore-efl.c: __trm_app_info_send_socket(242) > access
10-03 22:51:18.271+0900 D/AUL_AMD ( 2791): amd_launch.c: __e17_status_handler(2891) > pid(7216) status(3)
10-03 22:51:18.271+0900 D/AUL_AMD ( 2791): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
10-03 22:51:18.291+0900 D/DATA_PROVIDER_MASTER( 2961): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2913 is paused
10-03 22:51:18.291+0900 D/DATA_PROVIDER_MASTER( 2961): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
10-03 22:51:18.291+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __provider_pause_cb(294) > widget obj was paused
10-03 22:51:18.291+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __check_status_for_cgroup(142) > enter background group
10-03 22:51:18.291+0900 W/AUL     ( 2963): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2963, appid: org.tizen.calendar.widget, status: bg
10-03 22:51:18.291+0900 D/AUL_AMD ( 2791): amd_launch.c: __e17_status_handler(2897) > back key ungrab
10-03 22:51:18.291+0900 D/AUL_AMD ( 2791): amd_status.c: _status_update_app_info_list(456) > pid(7216) status(3)
10-03 22:51:18.291+0900 D/AUL_AMD ( 2791): amd_status.c: _status_update_app_info_list(468) > pid(7216) appid(org.example.chattingapp) pkgid(org.example.chattingapp) status(3)
10-03 22:51:18.291+0900 D/AUL     ( 2791): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.chattingapp
10-03 22:51:18.291+0900 W/AUL     ( 2791): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7216, appid: org.example.chattingapp, status: fg
10-03 22:51:18.291+0900 D/RESOURCED( 2895): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2963, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
10-03 22:51:18.291+0900 D/RESOURCED( 2895): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2963
10-03 22:51:18.291+0900 D/RESOURCED( 2895): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2963, appname = org.tizen.calendar.widget
10-03 22:51:18.291+0900 D/RESOURCED( 2895): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2963
10-03 22:51:18.291+0900 D/RESOURCED( 2895): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7216
10-03 22:51:18.291+0900 D/RESOURCED( 2895): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7216, proc_name: org.example.chattingapp, cg_name: foreground, oom_score_adj: 200
10-03 22:51:18.291+0900 D/RESOURCED( 2895): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7216
10-03 22:51:18.401+0900 D/RESOURCED( 2895): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7216, appname = org.example.chattingapp, pkgname = org.example.chattingapp
10-03 22:51:18.401+0900 D/RESOURCED( 2895): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7216, appname = org.example.chattingapp
10-03 22:51:18.401+0900 D/RESOURCED( 2895): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7216
10-03 22:51:18.401+0900 I/RESOURCED( 2895): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
10-03 22:51:18.401+0900 I/RESOURCED( 2895): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
10-03 22:51:18.441+0900 D/AUL_AMD ( 2791): amd_launch.c: __e17_status_handler(2910) > pid(7216) status(0)
10-03 22:51:18.961+0900 D/AUL_PAD ( 2959): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
10-03 22:51:18.961+0900 D/AUL_PAD ( 7226): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
10-03 22:51:18.961+0900 D/AUL_PAD ( 2959): sigchild.h: __send_app_launch_signal(131) > send launch signal done
10-03 22:51:18.961+0900 E/RESOURCED( 2895): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.594
10-03 22:51:19.111+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c01088, cursor pos : 1
10-03 22:51:19.111+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8c01088, bidi direction : 0x1
10-03 22:51:19.241+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c01088, cursor pos : 2
10-03 22:51:19.481+0900 D/AUL_AMD ( 2791): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.chattingapp /opt/usr/apps/org.example.chattingapp/bin/chattingapp
10-03 22:51:19.481+0900 D/RUA     ( 2791): rua.c: rua_add_history(179) > rua_add_history start
10-03 22:51:19.481+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c01088, cursor pos : 3
10-03 22:51:19.481+0900 D/RUA     ( 2791): rua.c: rua_add_history(247) > rua_add_history ok
10-03 22:51:19.851+0900 D/PROCESSMGR( 2828): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601338 
10-03 22:51:19.851+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8c01088
10-03 22:51:19.851+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-03 22:51:19.851+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8c01088
10-03 22:51:19.851+0900 D/ISE_DEFAULT( 3072): ise.cpp: on_focus_out(251) > Enter
10-03 22:51:19.851+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_focus_in(1534) > ctx : 0xb8c595a0. set autocapital type : 0
10-03 22:51:19.861+0900 D/ISE_DEFAULT( 3072): ise.cpp: on_focus_in(245) > Enter
10-03 22:51:19.861+0900 D/ISE_DEFAULT( 3072): ise.cpp: ise_focus_in(824) > ic : 1c310023 , 0 , g_ic : e7e0023 , 0, g_focused_ic : 0 , 1
10-03 22:51:19.861+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_focus_in(1551) > ctx : 0xb8c595a0. on demand : 0
10-03 22:51:19.861+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-03 22:51:19.861+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c595a0, cursor pos : 0
10-03 22:51:19.861+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_filter_event(2143) > [Mouse-up event] ctx : 0xb8c595a0
10-03 22:51:19.861+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: isf_imf_context_input_panel_show(599) > H/W keyboard is existed.
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): launchpad_loader.c: main(588) > sleeping 1 sec...
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(52) > max_cmdline_size = 1053
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7cc9760
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(69) > get pre-initialization function
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(73) > get shutdown function
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7cc9a40
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7ccb640
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(69) > get pre-initialization function
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preload.h: __preload_init(73) > get shutdown function
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): preexec.h: __preexec_init(76) > preexec start
10-03 22:51:20.001+0900 D/AUL_PAD ( 7226): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
10-03 22:51:20.001+0900 D/AUL     ( 7226): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
10-03 22:51:20.001+0900 D/AUL     ( 7226): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
10-03 22:51:20.001+0900 D/AUL     ( 7226): process_pool.c: __connect_to_launchpad(132) > send(7226) : 4
10-03 22:51:20.001+0900 D/AUL     ( 7226): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
10-03 22:51:20.001+0900 D/AUL_PAD ( 2959): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 7226
10-03 22:51:20.091+0900 D/AUL_PAD ( 7226): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
10-03 22:51:20.101+0900 D/AUL_PAD ( 7226): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
10-03 22:51:20.101+0900 D/AUL_PAD ( 7226): launchpad_loader.c: main(693) > [candidate] ecore handler add
10-03 22:51:20.101+0900 D/AUL_PAD ( 7226): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
10-03 22:51:20.371+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c595a0, cursor pos : 1
10-03 22:51:20.371+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_bidi_direction_set(2303) > ctx : 0xb8c595a0, bidi direction : 0x1
10-03 22:51:20.431+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c595a0, cursor pos : 2
10-03 22:51:20.591+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_cursor_position_set(1679) > ctx : 0xb8c595a0, cursor pos : 3
10-03 22:51:20.851+0900 D/PROCESSMGR( 2828): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
10-03 22:51:20.981+0900 D/PROCESSMGR( 2828): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601338 
10-03 22:51:20.981+0900 D/IMMODULE( 7216): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8c595a0
10-03 22:51:20.981+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
10-03 22:51:20.981+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8c595a0
10-03 22:51:20.981+0900 D/ISE_DEFAULT( 3072): ise.cpp: on_focus_out(251) > Enter
10-03 22:51:21.111+0900 D/IMMODULE( 7216): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
10-03 22:51:21.111+0900 D/ISF_PANEL_EFL( 3061): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
10-03 22:51:21.111+0900 D/ISF_PANEL_EFL( 3061): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
10-03 22:51:21.111+0900 D/ISF_PANEL_EFL( 3061): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
10-03 22:51:21.111+0900 D/ISF_PANEL_EFL( 3061): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-03 22:51:21.111+0900 D/SCIM_HELPER( 3072): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
10-03 22:51:21.111+0900 D/LIBSCL_UI( 3072): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2600009 (basewin 0x8000321a mag 0x8000fc7f)
10-03 22:51:21.141+0900 D/LIBSCL_UI( 3072): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2600003 (basewin 0x8000321a mag 0x8000fc7f)
10-03 22:51:21.141+0900 D/ISE_DEFAULT( 3072): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
10-03 22:51:21.921+0900 D/AUL_AMD ( 2791): amd_status.c: __app_terminate_timer_cb(442) > pid(7200)
10-03 22:51:21.921+0900 W/AUL_AMD ( 2791): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
10-03 22:51:22.361+0900 D/PROCESSMGR( 2828): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601338 
10-03 22:51:23.281+0900 D/APP_CORE( 2913): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
10-03 22:51:23.281+0900 I/APP_CORE( 2913): appcore-efl.c: __do_app(496) > [APP 2913] Event: MEM_FLUSH State: PAUSED
10-03 22:51:23.281+0900 D/APP_CORE( 2913): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
10-03 22:51:23.281+0900 D/APP_CORE( 2913): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2913
10-03 22:51:23.281+0900 D/APP_CORE( 2913): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
10-03 22:51:23.281+0900 D/RESOURCED( 2895): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2913
10-03 22:51:23.371+0900 D/PROCESSMGR( 2828): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x601338 
10-03 22:51:23.481+0900 D/AUL_PAD ( 2959): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
10-03 22:51:23.481+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
10-03 22:51:23.481+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
10-03 22:51:23.481+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
10-03 22:51:23.481+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
10-03 22:51:23.481+0900 D/AUL_PAD ( 2959): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
10-03 22:51:23.481+0900 D/AUL_PAD ( 2959): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
10-03 22:51:23.481+0900 I/AUL_PAD ( 2959): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 7216 pgid = 7216
10-03 22:51:23.481+0900 I/AUL_PAD ( 2959): sigchild.h: __sigchild_action(142) > dead_pid(7216)
10-03 22:51:23.491+0900 W/CRASH_MANAGER( 7229): worker.c: worker_job(1204) > 1107216636861147550268
