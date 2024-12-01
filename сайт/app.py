import pyodbc
import os
from flask import Flask, render_template

relative_path = "AAAAAAAAAAAAAA.mdb"
absolute_path = os.path.abspath(relative_path)

app = Flask(__name__)

def get_db_connection():
    conn = pyodbc.connect(r'DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=' + absolute_path + ';')
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