# Task 3
By **Seif El-Din Sweilam** _Section 2_

## Description
* Design and implement a `struct` for the students
* Student is identified by an ID, a name, a gender, and his courses
* Define a `struct` for courses which includes the course code, name and degree
* Define all required attributes, setters, getters, methods and indexers _if needed_
* In main method, Print course data for each student (using indexers)

## Implementation

**Student struct**
```c#
struct Student {
    private int id;
    private string name;
    private string gender;
    private Course[] courses;

    public Student(int id, string name, string gender, params Course[] courses) {
        this.id = id;
        this.name = name;
        this.gender = gender;
        this.courses = courses;
    }

    public int ID {
        set { id = value; }
        get { return id; }
    }

    public string Name {
        set { name = value; }
        get { return name; }
    }

    public string Gender {
        set { gender = value; }
        get { return gender; }
    }

    public int CoursesCount {
        get { return courses.Length; }
    }

    public Course? this[string code] {
        get {
            foreach (Course course in courses) {
                if (course.Code == code) {
                    return course;
                }
            }
            return null;
        }
    }

    public double OverallDegree {
        get {
            return courses.Sum((course) => course.Degree) / courses.Length;
        }
    }
}
```

**Course struct**
```c#
struct Course {
    string code;
    string name;
    double degree;

    public Course(string code, string name, double degree) {
        this.code = code;
        this.name = name;
        this.degree = degree;
    }

    public string Code {
        set { code = value; }
        get { return code; }
    }

    public string Name {
        set { name = value; }
        get { return name; }
    }

    public double Degree {
        set { degree = value; }
        get { return degree; }
    }
}
```

**Program class**
```c#
class Program {
    public static void Main() {
        Course math1 = new Course("BAS01", "Math 1", 78);
        Course math2 = new Course("BAS02", "Math 2", 82);
        Course physics1 = new Course("BAS11", "Physics 1", 80);
        Course physics2 = new Course("BAS11", "Physics 2", 76);
        Course programming = new Course("CSE01", "Introduction to Programming", 100);
        Student seif = new Student(1, "Seif El-Din Sweilam", "male", math1, physics1, math2, physics2, programming);

        DisplayStudent(seif, "BAS11", "CSE01");

        System.Console.WriteLine();

        Course math3 = new Course("BAS03", "Math 3", 71);
        Course math4 = new Course("BAS04", "Math 4", 80);
        Course control = new Course("CSE11", "Control Systems 1", 78);
        Course os = new Course("CSE21", "Operating Systems 1", 95);
        Course skills = new Course("GEN01", "Skills", 85);
        Student mohamed = new Student(2, "Mohamed Abdelfatah Selim", "male", math3, math4, control, os, skills);

        DisplayStudent(mohamed, "BAS03", "CSE11", "CSE21");
    }

    private static void DisplayStudent(Student student, params string[] codes) {
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine("| ID: {0, 32} |", student.ID);
        System.Console.WriteLine("| Name: {0, 30} |", student.Name);
        System.Console.WriteLine("| Gender: {0, 28} |", student.Gender);
        System.Console.WriteLine("| Degree: {0, 28} |", student.OverallDegree);
        System.Console.WriteLine("----------------------------------------");

        foreach (string code in codes) {
            Course? course = student[code];
            if (course != null) {
                System.Console.WriteLine("| Code: {0, 30} |", ((Course) course).Code);
                System.Console.WriteLine("| Name: {0, 30} |", ((Course) course).Name);
                System.Console.WriteLine("| Degree: {0, 28} |", ((Course) course).Degree);
                System.Console.WriteLine("----------------------------------------");
            }
        }
    }
}
```

## Runtime
```
----------------------------------------
| ID:                                1 |
| Name:            Seif El-Din Sweilam |
| Gender:                         male |
| Degree:                         83.2 |
----------------------------------------
| Code:                          BAS11 |
| Name:                      Physics 1 |
| Degree:                           80 |
----------------------------------------
| Code:                          CSE01 |
| Name:    Introduction to Programming |
| Degree:                          100 |
----------------------------------------

----------------------------------------
| ID:                                2 |
| Name:       Mohamed Abdelfatah Selim |
| Gender:                         male |
| Degree:                         81.8 |
----------------------------------------
| Code:                          BAS03 |
| Name:                         Math 3 |
| Degree:                           71 |
----------------------------------------
| Code:                          CSE11 |
| Name:              Control Systems 1 |
| Degree:                           78 |
----------------------------------------
| Code:                          CSE21 |
| Name:            Operating Systems 1 |
| Degree:                           95 |
----------------------------------------
```