   M S B A M L   `   `   `  ����  labfinal    labfinal.StudentCourses   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Student Courses Form��5   	   $	��500��6&   $	��800��63   .��5      �  � RowDefinitions 5   
   �� 5	      $��* �6   �� 5
      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��studentsDataGrid��5      $��0��6+      AutoGenerateColumns$
 True��68   $��10q�6S   �� 5      $��Search Students:��6   $
��Left=�6(   $	��Top=�6C   $��	10,10,0,0q�6[   �� 5   
   -   5        $��searchStudentsTextBox��5      $��1��6/   $	��150��6<   $��	10,5,0,10q�6H   5        5   
   -   5        $��coursesDataGrid��5      $��2��6*   $
 True��67   $��10q�6R   �� 5   
   $��Search Courses:��6   $
��Left=�6*   $	��Top=�6E   $��3��6]   $��	10,10,0,0q�6j   �� 5   
   -   5        $��searchCoursesTextBox��5      $��3��6.   $	��150��6;   $��	10,5,0,10q�6G   5      5      5      