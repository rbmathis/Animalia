namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hoolock;

/// <summary>
/// Interface defining characteristics of Hoolock (genus).
/// </summary>
public interface IHoolock
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
