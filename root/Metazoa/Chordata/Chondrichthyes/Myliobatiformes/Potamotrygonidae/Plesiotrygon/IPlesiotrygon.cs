namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Plesiotrygon;

/// <summary>
/// Interface defining characteristics of Plesiotrygon (genus).
/// </summary>
public interface IPlesiotrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
