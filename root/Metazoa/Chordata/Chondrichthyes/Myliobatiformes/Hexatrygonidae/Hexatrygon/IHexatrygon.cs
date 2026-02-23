namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Hexatrygonidae.Hexatrygon;

/// <summary>
/// Interface defining characteristics of Hexatrygon (genus).
/// </summary>
public interface IHexatrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
