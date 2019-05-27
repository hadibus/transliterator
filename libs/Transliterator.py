import yaml as Yaml

class Transliterator:
    def __init__(self, arg):
            self.initRules(arg)

    def initRules(self, arg):
        if type(arg) is not str:
            raise TypeError("Type passed must be str")
        with open(arg, 'r') as f:
            self.rules = Yaml.safe_load(f)