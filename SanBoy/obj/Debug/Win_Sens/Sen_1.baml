   M S B A M L   `   `   `  ????A  =SanBoy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SanBoySanBoy  5   	       SanBoy.Win_Sens.Sen_1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:SanBoy     5   	   X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     ? Title$
  YSSE??5	   	   $	??900??6   $
??1200??6#    ? WindowStartupLocation$ CenterScreen=?5
   	    ? WindowStyle$
 None=?5   	   
??????  ? AllowsTransparency . .??5      ??  ?? CornerRadius$ 10??6   $??1q?5      $??0??6!   ??5   
   ?? 5       ?? 
StartPoint$	 0,0&?6"    ?? EndPoint$	 1,1&?63   .??5      ?    winBorderColor1 ? Color# [  6    ? Offset$ 0Q?6H   ? 5        winBorderColor2# [ 6   $	 0.5Q?6H   ? 5        winBorderColor3# [ 6   $ 1Q?6H   5      ._?5   
   ? 	 ? RowDefinitions	 5      ?? 5      $	??82* ?6    ?? 5      $
??267* ?6    ?? 5      $	??42* ?6    ?? 5      $	??58* ?6    
 ? ColumnDefinitions
 5      ?? 5       $
??169* ?6#   ?? 5!      $
??810* ?6#   ?? 5"      $
??219* ?6#   .+?5$      ?? $ 10??6   $??3??6'   $??4??6;   ??5%      ?? 5&      $	 0,0&?6*   $ 1,0.7&?6;   .??5'      ?   secondaryBackColor1# [ 6'   $ 0Q?6T   ? 5(        secondaryBackColor2# [ 6'   $ 1Q?6T   5)      5-      ?? 5.      $??0??6   $??0??6)   $??10 10 10 10q?66   .+?50      ??  ?? Orientation$ 
Horizontal=?6   .+?51      ?? $??/Resources/DM1_logo.png??6   $	??150??6=   $	??140??6I   53      55      ? 57      $??3??6   $??4??6'   	 59      ?? 5;      $??25 ?6$   ?? 5<      $
??215* ?6$   ?? 5=      $	??76* ?6$   .+?5?      ?? -   5         ??Name$ pnlControlBar??5?      $??0??5@   !   $ 
Horizontal=?5A   !   $??RightToLeft=?5B   !   
?????? $??0,0,5,0q?5D   !   .+?5G      ?? -   5         ??Name$ btnClose??5G        controlButton#??[ 5H   !    
 color4
 ? Tag# [ 5I   !   .??5K      !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=?6'     controlButtonIcon#??[ 64   5L      ?? 5M      -   5        $ btnMaximize??5M      #??[ 5N   !    
 color6# [ 5O   !   .??5Q        $ Square=?6'   #??[ 65   5R      ?? 5S      -   5        $ btnMinimize??5S      #??[ 5T   !    
	 color8# [	 5U   !   .??5W        $ WindowMinimize=?6'   $??12??6=   #??[ 6H   5X      5Y      5Z      ?? 5^      $ 10??6   $??3??6'   $??2??6;   $??2??6H   $??1q?6Y   $??30 30 30 30q?6m   ??5_      ?? 5`      $	 0,0&?6*   $ 1,0.7&?6;   .??5a      ? # [  6'   $ 0Q?6P   ? 5b      # [ 6'   $	 0.5Q?6P   ? 5c      # [ 6'   $ 1Q?6P   5d      5j      ? 5u      -   5         ?Name$
 TS_1??5u      $??4??6"   $??0??63   $??4??6C   ? 5v      -   5        $
 TS_2??5v      $??4??6"   $??0??63   $??4??6C   ? 5w      -   5        $
 TS_3??5w      $??4??6"   $??0??63   $??4??6C   ? 5x      -   5        $
 TS_4??5x      $??4??6"   $??0??63   $??4??6C   5z      5{      5|      