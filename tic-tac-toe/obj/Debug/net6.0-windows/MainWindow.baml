   M S B A M L   `   `   `  ????F  Btic-tac-toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:tic_tac_toetic_tac_toe  5   	       tic_tac_toe.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:tic_tac_toe     5   	     ? Title$  
MainWindow??5   	   $	??600??5	   	   $
??1000??5
   	   .??5      ? .+?5   
   ?? -   5         ??Name$ userVsUserButton??5      $??	User-User??5      $
??Left=?5      $??156,257,0,0q?5      $	??Top=?5      $??50??5      $	??176??5      ???	#FFC87C7C$??24(?5   D   ?? 5   
   -   5        $ userVsComputerButton??5      $??User-Computer??5      $
??Left=?5      $??448,254,0,0q?5      $	??Top=?5      $??56??5      $	??236??5       J? RenderTransformOrigin$ 2.967,6.887&?5   1   ???	#FFC87C7C$??20(?6l   ?? 5   
   -   5        $ resumeButton??5      $??Resume Game??5      $??566,427,229,0q?5      $	??Top=?5      $??63??5       ???	#FFC87C7C$??24(?5!   D   ?? 5"   
   -   5         ??Name$ 
alertLabel??5"      $??Center=?5#      $??	0,410,0,0q?5$      $	??Top=?5%      $	??430??5&      $??30??5'      ?? 5(   
   -   5         ??Name$ pageTextBox??5(      $??Center=?5)       ?? TextWrapping$
 Wrap=?5*      $??Tic-Tac-Toe ??5+      $	??Top=?5,      $	??687??5-      $	??120??5.       ?? TextAlignment$ Center=?5/      $??Center=?50      $??Center=?51      $
??Bold"?52      $??48(?53      ???	#FF1E1010???	#FFE8DADA67   ?? 54   
   -   5        $ Wants_to_play_??54      $??Wants to play???6(   $
??Left=?6A   $??285,125,0,0q?6\   $	??Top=?6q   ???	#FF5C1717???	#FFDDCFCF$??36(?6?   $??71??6?   $	??298??6?   $ -0.039,0.764&?6?   ?? 55   
   -   5        $ Wants_to_play_1??55      $??Wants to resume game???6)   $
??Left=?6I   $??
79,425,0,0q?6d   $	??Top=?6x   ???	#FF5C1717???	#FFDDCFCF$??36(?6?   $??71??6?   $	??421??6?   56      57      