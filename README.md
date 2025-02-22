# F# Mutability Bug

This repository demonstrates a common error in F# related to the confusion between mutable and immutable variables.  The code in `bug.fs` shows how reassigning a mutable variable does not automatically update values that depend on it, unless the dependent value is also mutable.  The solution in `bugSolution.fs` shows ways to address this.