package main

func kangaroo(x1, v1, x2, v2 int) (result string) {
	result = "NO"

	if v2 > v1 || (v2 == v1 && x2 > x1) {
		return
	}

	var (
		loop = true
		time = 0
	)

	for loop {
		if time > 9999 {
			loop = false
		}

		var (
			range1 = x1 + v1*time
			range2 = x2 + v2*time
		)

		if range1 == range2 {
			result = "YES"
			loop = false
		}

		time++
	}

	return
}

func Kangaroo(x1, v1, x2, v2 int) (result string) {
	return kangaroo(x1, v1, x2, v2)
}
