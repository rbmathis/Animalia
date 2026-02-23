namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Neafrapus;

/// <summary>
/// Interface defining characteristics of Neafrapus (genus).
/// </summary>
public interface INeafrapus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
