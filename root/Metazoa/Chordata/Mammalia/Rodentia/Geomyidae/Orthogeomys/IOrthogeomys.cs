namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Orthogeomys;

/// <summary>
/// Interface defining characteristics of Orthogeomys (genus).
/// </summary>
public interface IOrthogeomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
