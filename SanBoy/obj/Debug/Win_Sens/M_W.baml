   M S B A M L   `   `   `  ????A  =SanBoy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SanBoySanBoy  5   	       
SanBoy.M_W   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:SanBoy     5   	   X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     ? Title$
  YSSE??5	   	   $	??500??6   $	??700??6#    ? WindowStartupLocation$ CenterScreen=?5
   	    ? WindowStyle$
 None=?5   	   
??????  ? AllowsTransparency . .??5      ??  ?? CornerRadius$ 10??6   $??1q?5      $??0??6!   ??5   
   ?? 5       ?? 
StartPoint$	 0,0&?6"    ?? EndPoint$	 1,1&?63   .??5      ?    winBorderColor1 ? Color# [  6    ? Offset$ 0Q?6H   ? 5        winBorderColor2# [ 6   $	 0.5Q?6H   ? 5        winBorderColor3# [ 6   $ 1Q?6H   5      ._?5   
   ? $??0??6   .+?5      ?? $ 10??6   ??5      ?? 5      $	 0,0&?6*   $ 1,0.7&?6;   .??5      ?   secondaryBackColor1# [ 6'   $ 0Q?6T   ? 5        secondaryBackColor2# [ 6'   $ 1Q?6T   5      ._?5!      ?? $??1??6   .+?5$      ?? 	 ?? Orientation$	 
Horizontal=?6!   $??
10,30,0,10q?5%   !   .+?5'      ?? $??/Resources/DM1_logo.png??6    $	??202??6A   $??0,0,0,10q?6M   $	??178??6_   ?? 5(      $??Yufus stercore??6$     titleColor2#??[ 5)   $   $??45(?5*   $   $??
Montserrat)?5+   $   $??Medium"?5,   $   $??Center=?5-   $   $??Center=?5.   $   $??60,0,0,0q?5/   $   $	??316??66   50      	? 54      -   5          
menuButton#??[ 54   "    
 color1

 ? Tag#
 [ 55   "   ??56   "   ?? *ShowHomeViewCommand+.??57      ?? $	 
Horizontal=?6%   .+?58      !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Play=?6+     menuButtonIcon#??[ 67   ?? 59      -   5         ??Name$	 txb??59   (   $??Играть??65    	 menuButtonText#??[	 6C   5:      5;      	? 5<      -   5        #??[ 5<   "    

 color2#
 [
 5=   "   ??5>   "   ?? *ShowCustomerViewCommand+.??5?      ?? $	 
Horizontal=?6%   .+?5@        $
 Bars=?6+   #??[ 67   ?? 5A      $.??(Настройки (Бета - тест)??6(   #??[	 6G   5B      5C      	? 5D      -   5        #??[ 5D   "    
 color3#
 [ 5E   "   ??5F   "   ?? *ShowCustomerViewCommand+.??5G      ?? $	 
Horizontal=?6%   .+?5H        $ PersonPregnant=?6+   #??[ 6A   ?? 5I      $??
Выйти??6(   #??[	 65   5J      5K      5L      5M      ? 5N       ? RowDefinitions 5P      ?? 5R      $??25 ?6$   ?? 5T      .+?5V      ?? -   5         ??Name$ pnlControlBar??5V      $??0??5W   !   $	 
Horizontal=?5X   !   $??RightToLeft=?5Y   !   
?????? $??0,0,5,0q?5[   !   .+?5^      ?? -   5         ??Name$ btnClose??5^        controlButton#??[ 5_   !    
 color4#
 [ 5`   !   .??5b        $ Xmark=?6'     controlButtonIcon#??[ 64   5c      ?? 5d      -   5        $ btnMaximize??5d      #??[ 5e   !    
 color6#
 [ 5f   !   .??5h        $ Square=?6'   #??[ 65   5i      ?? 5j      -   5        $ btnMinimize??5j      #??[ 5k   !    
 color8#
 [ 5l   !   .??5n        $ WindowMinimize=?6'   $??12??6=   #??[ 6H   5o      5p      5q      5r      5s      5t      