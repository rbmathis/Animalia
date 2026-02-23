namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Streptoprocne;

/// <summary>
/// Interface defining characteristics of Streptoprocne (genus).
/// </summary>
public interface IStreptoprocne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
