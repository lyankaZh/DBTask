   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	   %    Library.MainWindows.BooksWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$  Books��5   	   $��455.909��6   $��692.295��6(    � 	Resources 5
         Edit �� Text 
 Delete��%R   &	        &	      �� 5   
   $
 Edit��6'   �� 5   
   $ Delete��6)   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      6]     5   
   -   5        # [ 5      6a   .��5      � .+�5   
   c� -   5         c�Name$ toolBar��5      $
��Left=�6#   $	��Top=�6>   $	��686��6V   $��42��6b   .@�5      �� -   5         ��Name$ addBookButton��5      $��Add Book��6,   $��37��6?   $	��Top=�6K   $��75��6c   6n   �� 5      -   5        $ editBookButton��5      #��[  6-   $
��Edit��6N   $��37��6]   $	��Top=�6i   $��58��6�   �� 5      -   5        $ deleteButton��5      #��[ 6+   $��Delete��6N   $��37��6_   $	��Top=�6k   $��62��6�   �� 5      -   5         ��Name$ label��5      $��Search criteria:��6#   $��37��6>   $	��Top=�6J   $��0,5,0,-5q�6b   �� 5      -   5         ��Name$ searchCriteriaComboBox��5      $��37��67   $��0q�6C   $	��Top=�6N   $	��120��6f   	 �� Text$#	 Критерій пошуку��6r   ��6�   �� *	criterias+�� 5      -	   5        
 ��Name$
 searchTextTextBox��5      $��37��61   $��0q�6=    �� TextWrapping$
 Wrap=�6H   $	��Top=�6\   $	��120��6t   $��Enter text here...��6�   6�   �� 5      -
   5        $ searchButton��5      $��Search��6+   $��37��6<   $	��Top=�6H   $��59��6`   6k   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
booksTable��5      $
��Left=�6'   $��	10,61,0,0q�6B   $	��Top=�6U   $	��318��6m   $	��666��6z      AutoGenerateColumns .     
IsReadOnly .    CanUserReorderColumns .  ��6�   �� *Books+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *BookId+  5      $
 Name��6%    63   �� *Name+  5       $ Authors��6%    66   �� *	Authors+  5!      $
 Year��6%    63   �� *Year+  5"      $ Amount of pages��6%    6>   �� *Pages+  5#      $ Genre��6%    64   �� *Genre+  5$      $ Language��6%    67   �� *
Language+  5%      $ 	Publisher��6%    68   �� *	Publisher+  5&      $ Location��6%    67   �� *
Location+  5'      $ Is in Library��6&    6=   �� *IsInLibrary+5)      5*      5+      