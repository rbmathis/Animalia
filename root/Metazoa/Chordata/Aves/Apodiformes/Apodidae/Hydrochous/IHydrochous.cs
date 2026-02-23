namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Hydrochous;

/// <summary>
/// Interface defining characteristics of Hydrochous (genus).
/// </summary>
public interface IHydrochous
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
