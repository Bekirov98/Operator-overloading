using Operator_Overload;

GroupMate group = new GroupMate();

group.AddStudent(new Student("Mehemmed", "Bakirov", 25));
group.AddStudent(new Student("Mehriban", "Baghizada", 19));
group.Sort();
group.PrintStudents();