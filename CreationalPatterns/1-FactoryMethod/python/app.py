from flask import Flask

app = Flask(__name__)

@app.route("/api/accounts/saving", methods=['POST'])
def saving():
    return "saving"

@app.route("/api/accounts/checking", methods=['POST'])
def checking():
    return "saving"

@app.route("/api/accounts/<id>", methods=['GET'])
def accounts(id):
    return id