namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Paratrygon;

/// <summary>
/// Interface defining characteristics of Paratrygon (genus).
/// </summary>
public interface IParatrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
