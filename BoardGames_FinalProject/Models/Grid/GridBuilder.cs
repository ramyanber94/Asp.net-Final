﻿using BoardGames_FinalProject.Models.DTOs;
using BoardGames_FinalProject.Models.ExtensionMethods;
using Microsoft.AspNetCore.Http;

namespace BoardGames_FinalProject.Models.Grid
{
    public class GridBuilder
    {
        protected const string RouteKey = "currentroute";

        protected RouteDictionary routes { get; set; }
        protected ISession session { get; set; }

        public GridBuilder(ISession sess) {
            session = sess;
            routes = session.GetObject<RouteDictionary>(RouteKey) ?? new RouteDictionary();
        }

        public GridBuilder(ISession sess, GridDTO values, string defaultSortField) {
            session = sess;

            routes = new RouteDictionary(); 
            routes.PageNumber = values.PageNumber;
            routes.PageSize = values.PageSize;
            routes.SortField = values.SortField ?? defaultSortField;
            routes.SortDirection = values.SortDirection;

            SaveRouteSegments();
        }

        public void SaveRouteSegments() =>
            session.SetObject<RouteDictionary>(RouteKey, routes);

        public int GetTotalPages(int count) {
            int size = routes.PageSize;
            return (count + size - 1) / size;
        }
            
        public RouteDictionary CurrentRoute => routes;
    }
}
