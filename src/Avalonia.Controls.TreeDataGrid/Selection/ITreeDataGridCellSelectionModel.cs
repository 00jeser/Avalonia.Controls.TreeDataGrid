﻿using System;
using System.Collections.Generic;

namespace Avalonia.Controls.Selection
{
    /// <summary>
    /// Maintains the cell selection state for an <see cref="ITreeDataGridSource"/>.
    /// </summary>
    public interface ITreeDataGridCellSelectionModel : ITreeDataGridSelection
    {
        /// <summary>
        /// Occurs when the cell selection changes.
        /// </summary>
        event EventHandler<TreeDataGridCellSelectionChangedEventArgs>? SelectionChanged;
    }

    /// <summary>
    /// Maintains the cell selection state for an <see cref="ITreeDataGridSource"/>.
    /// </summary>
    public interface ITreeDataGridCellSelectionModel<T> : ITreeDataGridCellSelectionModel
        where T : class
    {
        /// <summary>
        /// Gets or sets a value indicating whether only a single cell can be selected at a time.
        /// </summary>
        bool SingleSelect { get; set; }

        /// <summary>
        /// Gets the indexes of the currently selected cells.
        /// </summary>
        IReadOnlyList<CellIndex> SelectedIndexes { get; }

        /// <summary>
        /// Occurs when the cell selection changes.
        /// </summary>
        new event EventHandler<TreeDataGridCellSelectionChangedEventArgs<T>>? SelectionChanged;
    }
}
