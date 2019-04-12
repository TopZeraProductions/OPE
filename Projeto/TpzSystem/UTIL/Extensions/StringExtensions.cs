namespace System.Extensions {

    public static class StringExtensions {
        public static int ToInt(this string value) {
            if (!string.IsNullOrEmpty(value)) {
                return int.Parse(value);
            }

            return 0;
        }

        public static double ToDouble(this string value) {
            return double.Parse(value);
        }

        public static bool IsEmpty(this string value) {
            return string.IsNullOrEmpty(value);
        }
    }

}