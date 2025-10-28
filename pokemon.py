from typing import List


class Pokemon:
    def __init__(self, name: str, type: (str, str), stage: int, region: str, misc: List[str], shiny: bool, obtained: bool):
        self.name = name
        self.type = type
        self.stage = stage
        self.region = region
        self.misc = misc
        self.shiny = shiny
        self.obtained = obtained
