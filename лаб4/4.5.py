class Temperature:
    def __init__(self, temperature = 0):
        self._temperature = temperature
    def to_fahrenheit(self):
        return (self.temperature * 1.8) + 32
    def to_celsium(self):
        return (self.temperature - 32) / 1.8
    @property
    def temperature(self):
        print("Getting value")
        return self._temperature
temp1 = Temperature(38)
print(Temperature.to_fahrenheit(temp1))
print(Temperature.to_celsium(temp1))


