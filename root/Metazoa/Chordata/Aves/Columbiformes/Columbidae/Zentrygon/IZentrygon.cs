namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Zentrygon;

/// <summary>
/// Interface defining characteristics of Zentrygon (genus).
/// </summary>
public interface IZentrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
