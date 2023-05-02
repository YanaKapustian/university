import java.awt.*;
import java.awt.event.*;
import java.sql.*;
import javax.swing.*;
import javax.swing.border.EmptyBorder;

public class UniversityDatabaseGUI extends JFrame {

    private final String DATABASE_URL = "jdbc:mysql://localhost:3306/university";
    private final String DATABASE_USERNAME = "root";
    private final String DATABASE_PASSWORD = "password";

    private final String[] UNIVERSITY_NAMES = {"Poltava National Technical University", "Poltava University of Economics and Trade", "Poltava Law Institute of the Yaroslav Mudryi National Law University", "Poltava V. G. Korolenko National Pedagogical University"};

    private JPanel contentPane;
    private JComboBox<String> universityComboBox;
    private JTextField facultyNameField;
    private JTextField groupNameField;
    private JTextField studentNameField;
    private JTextField teacherNameField;
    private JTextField departmentNameField;
    private JButton insertFacultyButton;
    private JButton insertGroupButton;
    private JButton insertStudentButton;
    private JButton insertTeacherButton;
    private JButton searchButton;
    private JTextArea searchResultsArea;

    private Connection connection;

    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    UniversityDatabaseGUI frame = new UniversityDatabaseGUI();
                    frame.setVisible(true);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });
    }

    public UniversityDatabaseGUI() throws SQLException {
        connectToDatabase();
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setBounds(100, 100, 800, 600);
        setTitle("University Database");

        contentPane = new JPanel();
        contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
        contentPane.setLayout(new GridLayout(5, 2, 5, 5));
        setContentPane(contentPane);

        universityComboBox = new JComboBox<>(UNIVERSITY_NAMES);
        contentPane.add(new JLabel("University"));
        contentPane.add(universityComboBox);

        facultyNameField = new JTextField();
        contentPane.add(new JLabel("Faculty Name"));
        contentPane.add(facultyNameField);

        groupNameField = new JTextField();
        contentPane.add(new JLabel("Group Name"));
        contentPane.add(groupNameField);

        studentNameField = new JTextField();
        contentPane.add(new JLabel("Student Name"));
        contentPane.add(studentNameField);

        teacherNameField = new JTextField();
        contentPane.add(new JLabel("Teacher Name"));
        contentPane.add(teacherNameField);

        departmentNameField = new JTextField();
        contentPane.add(new JLabel("Department Name"));
        contentPane.add(departmentNameField);

        insertFacultyButton = new JButton("Insert Faculty");
        insertFacultyButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                try {
                    insertFaculty();
                }
    });
    contentPane.add(insertFacultyButton);

    insertGroupButton = new JButton("Insert Group");
    insertGroupButton.addActionListener(new ActionListener() {
        public void actionPerformed(ActionEvent e) {
            try {
                insertGroup();
            } catch (SQLException ex) {
                ex.printStackTrace();
            }
        }
    });
    contentPane.add(insertGroupButton);

    insertStudentButton = new JButton("Insert Student");
    insertStudentButton.addActionListener(new ActionListener() {
        public void actionPerformed(ActionEvent e) {
            try {
                insertStudent();
            } catch (SQLException ex) {
                ex.printStackTrace();
            }
        }
    });
    contentPane.add(insertStudentButton);

    insertTeacherButton = new JButton("Insert Teacher");
    insertTeacherButton.addActionListener(new ActionListener() {
        public void actionPerformed(ActionEvent e) {
            try {
                insertTeacher();
            } catch (SQLException ex) {
                ex.printStackTrace();
            }
        }
    });
    contentPane.add(insertTeacherButton);

    searchButton = new JButton("Search");
    searchButton.addActionListener(new ActionListener() {
        public void actionPerformed(ActionEvent e) {
            try {
                searchDatabase();
            } catch (SQLException ex) {
                ex.printStackTrace();
            }
        }
    });
    contentPane.add(searchButton);

    searchResultsArea = new JTextArea();
    JScrollPane scrollPane = new JScrollPane(searchResultsArea);
    contentPane.add(scrollPane);

    connection.close();
    }
    
    private void connectToDatabase() throws SQLException {
        connection = DriverManager.getConnection(DATABASE_URL, DATABASE_USERNAME, DATABASE_PASSWORD);
    }
    
    private void insertFaculty() throws SQLException {
        String universityName = (String) universityComboBox.getSelectedItem();
        String facultyName = facultyNameField.getText();
        String departmentName = departmentNameField.getText();
    
        String query = "INSERT INTO faculties (university_name, faculty_name, department_name) VALUES (?, ?, ?)";
        PreparedStatement statement = connection.prepareStatement(query);
        statement.setString(1, universityName);
        statement.setString(2, facultyName);
        statement.setString(3, departmentName);
        statement.executeUpdate();
        JOptionPane.showMessageDialog(contentPane, "Faculty inserted successfully!");
    }
    
    private void insertGroup() throws SQLException {
        String facultyName = facultyNameField.getText();
        String groupName = groupNameField.getText();
    
        String query = "INSERT INTO groups (faculty_name, group_name) VALUES (?, ?)";
        PreparedStatement statement = connection.prepareStatement(query);
        statement.setString(1, facultyName);
        statement.setString(2, groupName);
        statement.executeUpdate();
        JOptionPane.showMessageDialog(contentPane, "Group inserted successfully!");
    }
    
    private void insertStudent() throws SQLException {
        String groupName = groupNameField.getText();
        String studentName = studentNameField.getText();
    
        String query = "INSERT INTO students (group_name, student_name) VALUES (?, ?)";
        PreparedStatement statement = connection.prepareStatement(query);
        statement.setString(1, groupName);
        statement.setString(2, studentName);
        statement.executeUpdate();
        JOptionPane.showMessageDialog(contentPane, "Student inserted successfully!");
    }
    
    private void insertTeacher() throws SQLException {
        String facultyName = facultyNameField.getText();
        String teacherName = teacherNameField.getText();
    
        String query = "INSERT INTO teachers (faculty_name, teacher_name) VALUES (?, ?)";
        PreparedStatement statement = connection.prepareStatement(query);
        statement.setString(1, facultyName);
        statement.setString(2, teacherName);
        statement.executeUpdate();
        JOptionPane.showMessageDialog(contentPane, "Teacher inserted successfully!");
    }
    
    private void searchDatabase() throws SQLException {
        String searchTerm = JOptionPane.showInputDialog(contentPane, "Enter search term:");
        String query = "SELECT * FROM faculties WHERE university_name = ? OR faculty_name = ? OR department_name = ? " +
            "UNION SELECT * FROM groups WHERE faculty_name = ? OR group_name = ? " +
                       "UNION SELECT * FROM students WHERE group_name = ? OR student_name = ? " +
            "UNION SELECT * FROM teachers WHERE faculty_name = ? OR teacher_name = ?";
    PreparedStatement statement = connection.prepareStatement(query);
    for (int i = 1; i <= 8; i++) {
        statement.setString(i, searchTerm);
    }
    ResultSet resultSet = statement.executeQuery();
    StringBuilder searchResults = new StringBuilder();
    while (resultSet.next()) {
        String universityName = resultSet.getString("university_name");
        String facultyName = resultSet.getString("faculty_name");
        String departmentName = resultSet.getString("department_name");
        String groupName = resultSet.getString("group_name");
        String studentName = resultSet.getString("student_name");
        String teacherName = resultSet.getString("teacher_name");

        if (universityName != null) {
            searchResults.append("University: ").append(universityName).append("\n");
        }
        if (facultyName != null) {
            searchResults.append("Faculty: ").append(facultyName).append("\n");
        }
        if (departmentName != null) {
            searchResults.append("Department: ").append(departmentName).append("\n");
        }
        if (groupName != null) {
            searchResults.append("Group: ").append(groupName).append("\n");
        }
        if (studentName != null) {
            searchResults.append("Student: ").append(studentName).append("\n");
        }
        if (teacherName != null) {
            searchResults.append("Teacher: ").append(teacherName).append("\n");
        }
        searchResults.append("\n");
    }
    searchResultsArea.setText(searchResults.toString());
}


