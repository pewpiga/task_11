   M S B A M L   `   `   `  ????B  >task_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:task_11task_11  5   	       task_11.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:task_11     5   	     ? Title$  Основное окно??5   	   $	??450??6   $	??800??6,   .??5	      ? $??
10,10,10,9q?6    ? ColumnDefinitions 5
   
   ?? 5      ?? 5      .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ClientsGrid??5         AutoGenerateColumns$
 True??6(   $??	0,0,370,0q?6C   $??2??6?   ?? 5   
   -   5         ??Name$ SaveChanges??5      $+??%Сохранить изменения??6&   $??
25,0,150,0q?6D    J? RenderTransformOrigin$ 0.505,0.503&?6X   $??34??6|   $	??Top=?6?   ${?False??6?   $??1??6?   ? 5   
   -   5         ?Name$ AddClientGrid??5      $??1??6&   $??	0,90,0,90q?66   $??Center=?6I   $	??234??6f   $y?Hidden=?6r   .+?5      ?? -   5         ??Name$ SecondNameTB??5      $??120,39,10,0q?6,    ?? TextWrapping$
 Wrap=?6A   $	??Top=?6U   ?? 5      -   5        $ FirstNameTB??5      $??120,62,10,0q?6+   $
 Wrap=?6@   $	??Top=?6T   ?? 5      -   5        $ 
LastNameTB??5      $??120,85,10,0q?6*   $
 Wrap=?6?   $	??Top=?6S   ?? 5      -   5        $ PhoneTB??5      $??120,109,10,0q?6'   $
 Wrap=?6=   $	??Top=?6Q   ?? 5      -   5        $ 
PassportTB??5      $??120,131,10,0q?6*   $
 Wrap=?6@   $	??Top=?6T   ?? 5      $??Фамилия??6   $??	60,34,0,0q?6&   $	??Top=?69   $
??Left=?6Q   $??60??6l   $??1??6w   ?? 5      $??Имя??6   $??	87,58,0,0q?6"   $	??Top=?65   $
??Left=?6M   $??33??6h   $??1??6s   ?? 5      $??Отчество??6   $??	59,81,0,0q?6'   $	??Top=?6:   $
??Left=?6R   $??61??6m   $??1??6x   ?? 5      $??Телефон??6   $??
63,104,0,0q?6&   $	??Top=?6:   $
??Left=?6R   $??57??6m   $??1??6x   ?? 5      $??Паспорт??6   $??
64,127,0,0q?6&   $	??Top=?6:   $
??Left=?6R   $??56??6m   $??1??6x   ?? 5      -	   5        $ AddClientButton??5      $%??Добавить клиента??6.   $
??Left=?6I   $??
72,154,0,0q?6d   $	??Top=?6x   $ 0.505,0.503&?6?   $	??152??6?   $??35??6?   6?   5      5      5      