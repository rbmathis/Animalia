namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Mearnsia;

/// <summary>
/// Interface defining characteristics of Mearnsia (genus).
/// </summary>
public interface IMearnsia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
