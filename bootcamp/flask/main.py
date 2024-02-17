from flask import Flask
app = Flask(__name__)

# http://127.0.0.1:5000/

@app.route("/") # GET
def index():
    return "Hello, world!"

@app.route("/info") # GET
def info():
    return "Сайт создан компанией GeekBrains!"


if __name__ == "__main__":
    app.run()