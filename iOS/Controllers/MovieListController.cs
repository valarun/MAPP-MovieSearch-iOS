﻿using System;
using System.Collections.Generic;
using UIKit;

namespace MovieSearch.iOS
{
	public class MovieListController : UITableViewController
	{
		private List<Movie> _movieList;

		public MovieListController(List<Movie> movieList)
		{
			this._movieList = movieList;
		}

		public override void ViewDidLoad()
		{
			this.View.BackgroundColor = UIColor.FromRGB(245, 244, 244);
			this.Title = "Movie list";
			this.TableView.Source = new MovieListSource(this._movieList, OnSelectedMovie);
		}

		private void OnSelectedMovie(int row) 		{ 			this.NavigationController.PushViewController(new MovieInfoController(this._movieList[row]),false); 		}
	}
}