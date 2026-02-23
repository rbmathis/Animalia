namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Apus;

/// <summary>
/// Interface defining characteristics of Apus (genus).
/// </summary>
public interface IApus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
