using MGroup.MSolve.Discretization;
using MGroup.LinearAlgebra.Matrices;
using System.Collections.Generic;

namespace MGroup.Constitutive.Structural
{
	public interface IStructuralElementType : IElementType
	{
		IMatrix StiffnessMatrix();
		IMatrix MassMatrix();
		IMatrix DampingMatrix();
		IEnumerable<double[]> InterpolateElementModelQuantities(IEnumerable<IElementModelQuantity<IStructuralDofType>> quantities);
		IEnumerable<double[]> IntegrateElementModelQuantities(IEnumerable<IElementModelQuantity<IStructuralDofType>> quantities);
	}
}
