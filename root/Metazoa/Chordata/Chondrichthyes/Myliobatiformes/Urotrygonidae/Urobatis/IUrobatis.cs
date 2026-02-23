namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urotrygonidae.Urobatis;

/// <summary>
/// Interface defining characteristics of Urobatis (genus).
/// </summary>
public interface IUrobatis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
