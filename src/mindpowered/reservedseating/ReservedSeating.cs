/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * An Library for Reserved Seating
 * Venues have Seats, Events are at Venues
 * Reservations are Seats at Events
 */
namespace mindpowered.reservedseating {
	public delegate void MyCallbackDelegate(object o);

	public class ReservedSeating
	{
		public ReservedSeating()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::reservedseating.ReservedSeating myinstance = new global::reservedseating.ReservedSeating(bus);
		}

		/**
		 * Create a new venue
		 * @param ownerId Who is responsible for this venue
		 * @param name Name of Venue
		 * @param maxPeople Maximum people permitted in venue
		 * @return {string} the id of the new venue
		*/
		public string CreateVenue(string ownerId, string name, double maxPeople)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ownerId);
			args.push(name);
			args.push(maxPeople);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CreateVenue", args, async_callback);
			return ret;
		}

		/**
		 * Create a new Venue Congiguration
		 * @param venueId Venue
		 * @param name Name of Venue Configuration
		 * @param maxPeople Maximum number of people permitted in this Venue Configuration
		 * @return {string} the id of the new Venue Configuration
		*/
		public string CreateVenueConfiguration(string venueId, string name, double maxPeople)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(venueId);
			args.push(name);
			args.push(maxPeople);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CreateVenueConfiguration", args, async_callback);
			return ret;
		}

		/**
		 * Create a new seat
		 * @param name The seat name
		 * @param seatClass The class of seat
		 * @param venueConfigId the Venue Configuration the seat belongs to
		 * @param nextTo the seats that are next to this one
		 * @param tableId the table this seat is at
		 * @param geometry Information about where the Seat is
		 * @return {string} the id of the new seat
		*/
		public string CreateSeat(string name, string seatClass, string venueConfigId, object[] nextTo, string tableId, object geometry)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(name);
			args.push(seatClass);
			args.push(venueConfigId);
			args.push(nextTo);
			args.push(tableId);
			args.push(geometry);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CreateSeat", args, async_callback);
			return ret;
		}

		/**
		 * Create a new Event
		 * @param ownerId Who is responsible for this event
		 * @param venueConfigId Venue Configuration to use for this event
		 * @param maxPeople Maximum people permitted in venue
		 * @return {string} the id of the new Event
		*/
		public string CreateEvent(string ownerId, string venueConfigId, double maxPeople)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ownerId);
			args.push(venueConfigId);
			args.push(maxPeople);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CreateEvent", args, async_callback);
			return ret;
		}

		/**
		 * Create a new Table
		 * @param venueConfigId Venue Configuration to use for this event
		 * @param minSeats Minimum number of people in a party to reserve the table
		 * @param maxSeats Maximum number of people that can sit at this table
		 * @param geometry Information about where the Table is
		 * @return {string} the id of the new Table
		*/
		public string CreateTable(string venueConfigId, double minSeats, double maxSeats, object geometry)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(venueConfigId);
			args.push(minSeats);
			args.push(maxSeats);
			args.push(geometry);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CreateTable", args, async_callback);
			return ret;
		}

		/**
		 * Create a new Order
		 * @param userId The user who is placing the reservation
		 * @param eventId The event that the order is for
		 * @param expires Timestamp when order expires and is considered abondoned
		 * @return {string} the id of the new Order
		*/
		public string CreateOrder(string userId, string eventId, double expires)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(userId);
			args.push(eventId);
			args.push(expires);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CreateOrder", args, async_callback);
			return ret;
		}

		/**
		 * Get a Venue
		 * @param id Venue ID
		 * @return {object} the Venue data as an object
		*/
		public object GetVenue(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetVenue", args, async_callback);
			return ret;
		}

		/**
		 * Get a Venue Configuration
		 * @param id Venue Configuration ID
		 * @return {object} the VenueConfiguration data as an object
		*/
		public object GetVenueConfiguration(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetVenueConfiguration", args, async_callback);
			return ret;
		}

		/**
		 * Get a Seat
		 * @param id Seat ID
		 * @return {object} the Seat data as an object
		*/
		public object GetSeat(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetSeat", args, async_callback);
			return ret;
		}

		/**
		 * Get an Event
		 * @param id Event ID
		 * @return {object} the Event data as an object
		*/
		public object GetEvent(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetEvent", args, async_callback);
			return ret;
		}

		/**
		 * Get a Table
		 * @param id Table ID
		 * @return {object} the Table data as an object
		*/
		public object GetTable(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetTable", args, async_callback);
			return ret;
		}

		/**
		 * Update a Venue
		 * @param data Venue data to update
		 * @param complete if set to true, missing fields should be deleted
		*/
		public void UpdateVenue(object data, bool complete)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(data);
			args.push(complete);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.UpdateVenue", args, async_callback);
		}

		/**
		 * Update a Venue Configuration
		 * @param data Venue Configuration data to update
		 * @param complete if set to true, missing fields should be deleted
		*/
		public void UpdateVenueConfiguration(object data, bool complete)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(data);
			args.push(complete);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.UpdateVenueConfiguration", args, async_callback);
		}

		/**
		 * Update a Seat
		 * @param data Seat data to update
		 * @param complete if set to true, missing fields should be deleted
		*/
		public void UpdateSeat(object data, bool complete)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(data);
			args.push(complete);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.UpdateSeat", args, async_callback);
		}

		/**
		 * Update an Event
		 * @param data Event data to update
		 * @param complete if set to true, missing fields should be deleted
		*/
		public void UpdateEvent(object data, bool complete)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(data);
			args.push(complete);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.UpdateEvent", args, async_callback);
		}

		/**
		 * Update a Table
		 * @param data Table data to update
		 * @param complete if set to true, missing fields should be deleted
		*/
		public void UpdateTable(object data, bool complete)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(data);
			args.push(complete);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.UpdateTable", args, async_callback);
		}

		/**
		 * Delete a Venue
		 * @param id Venue ID
		*/
		public void DeleteVenue(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.DeleteVenue", args, async_callback);
		}

		/**
		 * Delete a Venue Configuration
		 * Must be unavailable first
		 * @param id Venue Configuration ID
		*/
		public void DeleteVenueConfiguration(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.DeleteVenueConfiguration", args, async_callback);
		}

		/**
		 * Delete a Seat
		 * Venue Configuration must be unavailable first
		 * @param id Seat ID
		*/
		public void DeleteSeat(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.DeleteSeat", args, async_callback);
		}

		/**
		 * Delete an Event
		 * Events on sale must be cancelled before being deleted.
		 * @param id Event ID
		*/
		public void DeleteEvent(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.DeleteEvent", args, async_callback);
		}

		/**
		 * Delete a Table
		 * Venue Configuration must be unavailable first
		 * @param id Table ID
		*/
		public void DeleteTable(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.DeleteTable", args, async_callback);
		}

		/**
		 * Delete an Order
		 * Reservations must be cancelled first
		 * @param id Order ID
		*/
		public void DeleteOrder(string id)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(id);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.DeleteOrder", args, async_callback);
		}

		/**
		 * Complete order and convert holds into reservations
		 * @param orderId Order ID
		*/
		public void CompleteOrder(string orderId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(orderId);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CompleteOrder", args, async_callback);
		}

		/**
		 * Place a hold on a seat and add it to an order
		 * @param orderId Order ID
		 * @param seatId Seat ID
		*/
		public void AddSeatToOrder(string orderId, string seatId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(orderId);
			args.push(seatId);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.AddSeatToOrder", args, async_callback);
		}

		/**
		 * Keep an order from expiring and becoming abondoned
		 * @param orderId Order ID
		 * @param expires New timestamp when order will expire
		*/
		public void ContinueOrder(string orderId, double expires)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(orderId);
			args.push(expires);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.ContinueOrder", args, async_callback);
		}

		/**
		 * Automatically select some seats and add them to the order
		 * @param numSeats Number of seats to select
		 * @param seatClassPreference Which seat classes to prefer in order
		*/
		public void AutoSelect(double numSeats, object[] seatClassPreference)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(numSeats);
			args.push(seatClassPreference);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.AutoSelect", args, async_callback);
		}

		/**
		 * Cancel an event and all reservations for that event
		 * @param eventId Event ID
		*/
		public void CancelEvent(string eventId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(eventId);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CancelEvent", args, async_callback);
		}

		/**
		 * Cancel a reservation and release the seats
		 * @param orderId Order ID
		 * @param seatId Seat ID
		*/
		public void CancelReservation(string orderId, string seatId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(orderId);
			args.push(seatId);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.CancelReservation", args, async_callback);
		}

		/**
		 * Get all Seats and Tables for an Event
		 * @param eventId Event ID
		 * @param page page number
		 * @param perpage per page
		*/
		public void GetSeatsAndTablesForEvent(string eventId, double page, double perpage)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(eventId);
			args.push(page);
			args.push(perpage);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetSeatsAndTablesForEvent", args, async_callback);
		}

		/**
		 * Get any abondoned (expired) orders
		 * @param page page number
		 * @param perpage per page
		 * @return {object[]} abondoned orders
		*/
		public object[] FindAbandonedOrders(double page, double perpage)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(page);
			args.push(perpage);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.FindAbandonedOrders", args, async_callback);
			return ret;
		}

		/**
		 * Get a users orders
		 * @param userId User ID
		 * @param page page number
		 * @param perpage per page
		 * @return {object[]} orders for user
		*/
		public object[] GetOrdersForUser(string userId, double page, double perpage)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(userId);
			args.push(page);
			args.push(perpage);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetOrdersForUser", args, async_callback);
			return ret;
		}

		/**
		 * Get all Events marked on sale
		 * @param page page number
		 * @param perpage per page
		 * @return {object[]} events on sale
		*/
		public object[] GetAllEventsOnSale(double page, double perpage)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(page);
			args.push(perpage);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetAllEventsOnSale", args, async_callback);
			return ret;
		}

		/**
		 * Make a venue configuration available or unavailable.
		 * Must not have any events for sale using this venute configuration.
		 * @param venueConfigurationId Venue Configuration ID
		 * @param available availability
		*/
		public void UpdateVenueConfigurationAvailability(string venueConfigurationId, bool available)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(venueConfigurationId);
			args.push(available);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.UpdateVenueConfigurationAvailability", args, async_callback);
		}

		/**
		 * Get Venue Configurations for a Venue
		 * @param venueId Venue ID
		 * @return {object[]} the Venue Configurations for the specified Venue
		*/
		public object[] GetVenueConfigurations(string venueId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(venueId);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetVenueConfigurations", args, async_callback);
			return ret;
		}

		/**
		 * Get a summary of an Order
		 * @param orderId Order ID
		 * @return {object[]} the summary for the specified Order
		*/
		public object[] GetOrderSummary(string orderId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(orderId);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetOrderSummary", args, async_callback);
			return ret;
		}

		/**
		 * Get all Venues for an owner
		 * @param ownerId owner id
		 * @return {object[]} List of venues
		*/
		public object[] GetAllVenuesByOwner(string ownerId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ownerId);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("ReservedSeating.GetAllVenuesByOwner", args, async_callback);
			return ret;
		}

	}
}

