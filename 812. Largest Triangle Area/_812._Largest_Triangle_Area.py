class Solution:
    def largestTriangleArea(self, points: List[List[int]]) -> float:

        max_area = 0

        for i in range(len(points)):
            for j in range(len(points)):
                for k in range(len(points)):
                    if points[i] != points[j] and points[i] != points[k] and points[j] != points[k]:

                        new_area = self.area_problem_seven(points[i], points[j], points[k])
                        if new_area > max_area:
                            max_area = new_area

        return max_area

    def area_problem_seven(self, point_one: list[int], point_two: list[int],point_three: list[int]) -> float:

        area = (1/2) * abs(point_one[0] * (point_two[1] - point_three[1]) + point_two[0] * (point_three[1] - point_one[1]) +        point_three[0] * (point_one[1] - point_two[1]))

        return float(f"{area:.5f}")

