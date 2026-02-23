namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Kryptopterus;

/// <summary>
/// Interface defining characteristics of Kryptopterus (genus).
/// </summary>
public interface IKryptopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
