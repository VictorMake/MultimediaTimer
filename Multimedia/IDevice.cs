using System;
using System.ComponentModel;

namespace Multimedia
{
	/// <summary>
	/// Represents the basic functionality for all multimedia devices.
	/// </summary>
	public interface IDevice : IDisposable
	{
        /// <summary>
        /// Occurs when the IDevice has finished using a buffer.
        /// </summary>
        event EventHandler<BufferFinishedEventArgs> BufferFinished;

        /// <summary>
        /// Closes the IDevice.
        /// </summary>
        void Close();

        /// <summary>
        /// Resets the IDevice.
        /// </summary>
        void Reset();

        /// <summary>
        /// Gets the IDevice handle.
        /// </summary>
        int Handle
        {
            get;
        }

        /// <summary>
        /// Gets or sets the object used to marshal event-handler calls.
        /// </summary>
        ISynchronizeInvoke SynchronizingObject
        {
            get;
            set;
        }
	}

    /// <summary>
    /// Profides data for the BufferFinished event.
    /// </summary>
    public class BufferFinishedEventArgs : EventArgs
    {
        // The buffer that the IDevice is finished with.
        private byte[] buffer;

        /// <summary>
        /// Initializes a new instance of the BufferFinishedEventArgs class 
        /// with the specified buffer.
        /// </summary>
        /// <param name="buffer">
        /// The buffer that the IDevice is finished with.
        /// </param>
        public BufferFinishedEventArgs(byte[] buffer)
        {
            this.buffer = buffer;
        }

        /// <summary>
        /// Gets the buffer.
        /// </summary>
        /// <returns>
        /// The finished buffer.
        /// </returns>
        public byte[] GetBuffer()
        {
            return buffer;
        }
    }
}
