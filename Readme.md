# 🎓 Student Information System (C# Console App)

A simple console-based application to manage student records, course grades, and GPAs. Built with C# for educational and administrative use cases.

---

## 📌 Features

### ✅ Core Features
- Add new students with ID, name, email, and major
- Add courses and grades for each student
- Calculate and display GPA
- View all student summaries
- View detailed info for individual students
- Save and load data using JSON file

### 🌟 Stretch Features
- Delete students by ID
- Filter students by major
- Sort students by GPA

---

## 🛠 Technologies Used
- Language: **C#**
- Runtime: **.NET 6+**
- File Storage: `students.json` using `System.Text.Json`

---

## 🚀 Getting Started

1. Clone or download this repository.
2. Open the project in **Visual Studio 2022**.
3. Make sure you have a `students.json` file in the same directory.
4. Build and run the application.

---
## 🎥 Demo Video
👉 [Insert your YouTube link here]

The video will demonstrate:

How to add and view students

Adding courses and calculating GPA

Filtering and sorting

File loading and saving

--- 
## 🕒 Time Spent
- Total Time: ~25 hours

    Task	                 Time

    Planning & Design	     2 hr

    Coding Core Features     9 hr

    Stretch Features	     5 hr

    Debugging & Testing	     3 hr

    Writing README & Comments 2 hr

    Demo Video Recording	  4 hr

## 📄 Sample Data Format (`students.json`)

```json
[
  {
    "ID": "1001",
    "Name": "Alice Johnson",
    "Email": "alice@example.com",
    "Major": "Computer Science",
    "Courses": [
      { "Name": "Math", "Grade": 3.5 },
      { "Name": "Programming", "Grade": 3.8 }
    ]
  }
]
