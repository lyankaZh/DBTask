   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	   &     Library.MainWindows.BorrowWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$  BorrowWindow��5   	   $	��452��6   $	��762��6+    � 	Resources 5	         Edit �� Text 
 Delete  Mark��%z   &	        &	      &	 >     �� 5
   
   $
 Edit��6'   �� 5   
   $ Delete��6)   �� 5   
   $
 Mark��6'   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [ 5      6a     5   
   -   5        # [ 5      6]   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��582* �6   �� 5      $��7* �6   .+�5   
   c� -   5         c�Name$ toolBar��5      $	��Top=�6#   $��50��6;   .@�5      �� -   5         ��Name$ addOrderButton��5      $��	Add Order��6-   $��50��6A   $	��Top=�6M   $��75��6e   $��0,0,0,-5q�6p   6�   �� 5      -   5        $ deleteReaderButton��5      #��[ 61   $��Delete��6T   $��50��6e   $	��Top=�6q   $��44��6�   $��0,0,0,-5q�6�   �� 5      -   5        $ returnButton��5      #��[ 6,   $��Mark as returned��6M   $��50��6h   $	��Top=�6t   $��96��6�   $��0,0,0,-5q�6�   �� 5      -   5        $ deptorsButton��5      $��Deptors��6,   $��50��6>   $	��Top=�6J   $��75��6b   $��0,0,0,-5q�6m   6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ borrowTable��5      $��
16,55,10,0q�6(   $	��Top=�6<   $	��294��6T   	   AutoGenerateColumns	 .  
   
IsReadOnly
 .    CanUserReorderColumns .  ��6}   �� *
BorrowInfo+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ReaderId��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Reader.ReaderId+  5!      $ Reader��6%    65   �� *Reader+  5"      $ BookId��6%    65   �� *Book.BookId+  5#      $
 Book��6%    63   �� *Book+  5$      $ Borrow Date��6%    6:   �� *
BorrowDate+ �� StringFormat$ {0:dd.MM.yy}��  5%      $ Period��6%    65   �� *BorrowPeriodInDays+  5&      $ Return date��6%    6:   �� *ReturningDate+$ {0:dd.MM.yy}��5(      5*      5+      