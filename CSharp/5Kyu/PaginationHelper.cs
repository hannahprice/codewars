using System;
using System.Collections.Generic;
using System.Linq;
  
public class PagnationHelper<T>
{
  private readonly IList<T> _collection;
  private readonly int _maxPageSize;
  
  /// <summary>
  /// Constructor, takes in a list of items and the number of items that fit within a single page
  /// </summary>
  /// <param name="collection">A list of items</param>
  /// <param name="itemsPerPage">The number of items that fit within a single page</param>
  public PagnationHelper(IList<T> collection, int itemsPerPage)
  {
    _collection = collection;
    _maxPageSize = itemsPerPage;
  }

  /// <summary>
  /// The number of items within the collection
  /// </summary>
  public int ItemCount
  {
    get
    {
      return _collection.Count;
    }
  }

  /// <summary>
  /// The number of pages
  /// </summary>
  public int PageCount
  {
    get
    {
      double numberOfPages = (double)ItemCount / (double)_maxPageSize;
      return (int)Math.Ceiling(numberOfPages);
    }
  }

  /// <summary>
  /// Returns the number of items in the page at the given page index 
  /// </summary>
  /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
  /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
  public int PageItemCount(int pageIndex)
  {
    if (pageIndex < 0 || pageIndex >= PageCount){
      return -1;
    }
    
    if (pageIndex < PageCount - 1){
     return _maxPageSize;
    }
    else
    {
        var remainder = ItemCount % _maxPageSize;
        return remainder == 0 ? _maxPageSize : remainder;
    }
  }

  /// <summary>
  /// Returns the page index of the page containing the item at the given item index.
  /// </summary>
  /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
  /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
  public int PageIndex(int itemIndex)
  {
    for (int i = 0; i < PageCount; i++) {
     var itemIndexesInThisPage = Enumerable.Range(i * _maxPageSize, _maxPageSize).Where(x => x < ItemCount);
     var itemInThisPage = itemIndexesInThisPage.Contains(itemIndex);
     
     if (itemInThisPage){
      return i;
     }
    }
    
    return -1;
  }
}