namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

/// <summary>
/// Interface defining characteristics of Geomys (genus).
/// </summary>
public interface IGeomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
