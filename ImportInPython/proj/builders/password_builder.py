import sys
sys.path.append("../proj")  # mac
# *Локально проблему можно вылечить абсолютный маршрутом
# sys.path.append("..\\proj"); # windows
import random as r
from infrastructure.symbol_provider import *


def get_password(length: int) -> str:
    alphabet = get_digits() + get_lowercase() + get_uppercase()
    return "".join(r.choice(alphabet) for _ in range(length))
