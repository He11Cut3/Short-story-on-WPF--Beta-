   M S B A M L   `   `   `  ???? A  =SanBoy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SanBoySanBoy      
SanBoy.M_W   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:SanBoy     X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp    ? Title$
  YSSE??$	??500??$	??700?? ? WindowStartupLocation$ CenterScreen=? ? WindowStyle$
 None=?
??????  ? AllowsTransparency . .????  ?? CornerRadius$ 10??$??1q?$??0??????  ?? 
StartPoint$	 0,0&? ?? EndPoint$	 1,1&?.???    winBorderColor1 ? Color# [   ? Offset$ 0Q??   winBorderColor2# [ $	 0.5Q??   winBorderColor3# [ $ 1Q?._?? $??0??.+??? $ 10?????? $	 0,0&?$ 1,0.7&?.???   secondaryBackColor1# [ $ 0Q??   secondaryBackColor2# [ $ 1Q?._??? $??1??.+??? 	 ?? Orientation$	 
Horizontal=?$??
10,30,0,10q?.+??? $??/Resources/DM1_logo.png??$	??202??$??0,0,0,10q?$	??178???? $??Yufus stercore??  titleColor2#??[ $??45(?$??
Montserrat)?$??Medium"?$??Center=?$??Center=?$??60,0,0,0q?$	??316??	? -     
menuButton#??[  
 color1

 ? Tag#
 [ ???? *ShowHomeViewCommand+.???? $	 
Horizontal=?.+?!  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Play=?  menuButtonIcon#??[ ?? -    ??Name$	 txb??$??Играть?? 	 menuButtonText#??[	 	? -   #??[  

 color2#
 [
 ???? *ShowCustomerViewCommand+.???? $	 
Horizontal=?.+?  $
 Bars=?#??[ ?? $.??(Настройки (Бета - тест)??#??[	 	? -   #??[  
 color3#
 [ ???? *ShowCustomerViewCommand+.???? $	 
Horizontal=?.+?  $ PersonPregnant=?#??[ ?? $??
Выйти??#??[	 ?  ? RowDefinitions ?? $??25 ??? .+??? -    ??Name$ pnlControlBar??$??0??$	 
Horizontal=?$??RightToLeft=?
?????? $??0,0,5,0q?.+??? -    ??Name$ btnClose??  controlButton#??[  
 color4#
 [ .??  $ Xmark=?  controlButtonIcon#??[ ?? -   $ btnMaximize??#??[  
 color6#
 [ .??  $ Square=?#??[ ?? -   $ btnMinimize??#??[  
 color8#
 [ .??  $ WindowMinimize=?$??12??#??[ 