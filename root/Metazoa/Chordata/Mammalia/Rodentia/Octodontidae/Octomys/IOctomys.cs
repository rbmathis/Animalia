namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octomys;

/// <summary>
/// Interface defining characteristics of Octomys (genus).
/// </summary>
public interface IOctomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
