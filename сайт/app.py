import pyodbc
from flask import Flask, render_template

app = Flask(__name__)

def get_db_connection():
    conn = pyodbc.connect(r'DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=Z:\repos\pythonProject\AAAAAAAAAAAAAA.mdb;')
    return conn

@app.route('/')
def index():
    conn = get_db_connection()
    cursor = conn.cursor()
    cursor.execute('SELECT фио, код_филиала, балл FROM менеджеры')
    rows = cursor.fetchall()
    cursor.close()
    conn.close()
    return render_template('index.html', rows=rows)

if __name__ == '__main__':
    app.run(debug=True)