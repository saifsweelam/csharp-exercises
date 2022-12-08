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

    public Course this[int i] {
        set { courses[i] = value; }
        get { return courses[i]; }
    }

    public double OverallDegree {
        get {
            return courses.Sum((course) => course.Degree) / courses.Length;
        }
    }
}

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


class Program {
    public static void Main() {
        Course math1 = new Course("BAS01", "Math 1", 78);
        Course math2 = new Course("BAS02", "Math 2", 82);
        Course physics1 = new Course("BAS11", "Physics 1", 80);
        Course physics2 = new Course("BAS11", "Physics 2", 76);
        Course programming = new Course("CSE01", "Introduction to Programming", 100);
        Student seif = new Student(1, "Seif El-Din Sweilam", "male", math1, physics1, math2, physics2, programming);

        DisplayStudent(seif);

        System.Console.WriteLine();

        Course math3 = new Course("BAS03", "Math 3", 71);
        Course math4 = new Course("BAS04", "Math 4", 80);
        Course control = new Course("CSE11", "Control Systems 1", 78);
        Course os = new Course("CSE21", "Operating Systems 1", 95);
        Course skills = new Course("GEN01", "Skills", 85);
        Student mohamed = new Student(2, "Mohamed Abdelfatah Selim", "male", math3, math4, control, os, skills);

        DisplayStudent(mohamed);
    }

    private static void DisplayStudent(Student student) {
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine("| ID: {0, 32} |", student.ID);
        System.Console.WriteLine("| Name: {0, 30} |", student.Name);
        System.Console.WriteLine("| Gender: {0, 28} |", student.Gender);
        System.Console.WriteLine("| Degree: {0, 28} |", student.OverallDegree);
        System.Console.WriteLine("----------------------------------------");

        for (int i = 0; i < student.CoursesCount; i++) {
            Course course = student[i];
            System.Console.WriteLine("| Code: {0, 30} |", course.Code);
            System.Console.WriteLine("| Name: {0, 30} |", course.Name);
            System.Console.WriteLine("| Degree: {0, 28} |", course.Degree);
            System.Console.WriteLine("----------------------------------------");
        }
    }
}