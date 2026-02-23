namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urotrygonidae.Urotrygon;

/// <summary>
/// Interface defining characteristics of Urotrygon (genus).
/// </summary>
public interface IUrotrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
