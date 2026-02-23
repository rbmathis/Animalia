namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Leptotrygon;

/// <summary>
/// Interface defining characteristics of Leptotrygon (genus).
/// </summary>
public interface ILeptotrygon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
