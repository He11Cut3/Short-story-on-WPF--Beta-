   M S B A M L   `   `   `  ????A  =SanBoy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SanBoy.TemsSanBoy.Tems  5          SanBoy.Tems.T5   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SanBoy.Tems     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $	??82* ?6   ?? 5      $
??267* ?6   ?? 5      $	??42* ?6   ?? 5      $	??58* ?6    ? ColumnDefinitions 5   
   ?? 5      $
??169* ?6   ?? 5      $
??810* ?6   ?? 5      $
??219* ?6   .+?5   
   ??  ?? CornerRadius$ 10??6   $??3??6#   $??2??67   $??2??6D   $??1q?6U   $??30 30 30 30q?6i   ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$ 1,0.7&?67   .??5      ?    winBorderColor1 ? Color# [  6#    ? Offset$ 0Q?6L   ? 5        winBorderColor2# [ 6#   $	 0.5Q?6L   ? 5        winBorderColor3# [ 6#   $ 1Q?6L   5      ._?5       ?? -   5         ??Name$ Sensss_1??5       $?? ??5!      $
??Left=?5"      
???????$??	40 10 0 0q?5$      $??30(?5%      $4??./SanBoy;component/fonts/#Jolly Lodger Cyrillic)?5&       ? Triggers 5'      :? 5(      	 :? RoutedEvent$	 TextBlock.Loaded??6#   .[?5)      ?? .??5*      ?? .??5+   "   W? 
 ?? 
TargetName$
 Sensss_1??5,   )    ?? TargetProperty$ (TextBlock.Opacity)?5-   )    W? From$	 0.0X?5.   )   	 W? To$ 1X?64    g? Duration$ 0:0:0:1D?6;   5/      50      51      53      54      ?? 58   
   -   5         ??Name$ N3_IMG??58      $??/Resources/N3_img.jpg??6    $
??Auto??6?   $
??Auto??6L   $??0??6Z   $??1??6k   $??3??6x   $
??Fill=?6?   $??10 10 10 10q?6?   6?   ?? 5<   
   -   5        $??N6??5<       J? Opacity$ 0Q?6   $??1??6(   $??0??64   $??3??6D   $??1??6X   $??3??6e    5=      :? 5>      $	 Button.Click??6   .[?5?      ?? .??5@      ?? .??5A      W? $
 Sensss_1??5B   )   $ (TextBlock.Opacity)?5C   )   $	 0.0X?5D   )   $ 1X?64   $ 0:0:0:1D?6;   5E      5F      5G      5I      ? 5M   
   -   5         ?Name$
 TS_6??5M      $??4??6   $??0??6/   $??4??6?   5N      5O      