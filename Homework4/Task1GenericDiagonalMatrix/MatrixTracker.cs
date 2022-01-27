﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1GenericDiagonalMatrix
{
    class MatrixTracker<T>
    {
        DiagonalMatrix<T> InputMatrix;
        ElementChangedEventArgs<T> TrackedMatrixEvent;

        public MatrixTracker(DiagonalMatrix<T> inputMatrix)
        {
            InputMatrix = inputMatrix;
            InputMatrix.ElementChanged += trackedMatrixChanged;
        }

        public void trackedMatrixChanged(object sender, ElementChangedEventArgs<T> e)
        {
            TrackedMatrixEvent = e;
        }

        public void Undo()
        {
            InputMatrix[TrackedMatrixEvent.ElementIndex, TrackedMatrixEvent.ElementIndex] = TrackedMatrixEvent.OldValue;
        }
    }
}