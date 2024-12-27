/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
    // If the functions array is empty, return the identity function
    if (functions.length === 0) {
        return function(x) {
            return x;  // Identity function: returns the input as-is
        };
    }

    // Otherwise, return a function that applies the composed functions from right to left
    return function(x) {
        return functions.reduceRight((acc, fn) => fn(acc), x);
    };
};
/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */