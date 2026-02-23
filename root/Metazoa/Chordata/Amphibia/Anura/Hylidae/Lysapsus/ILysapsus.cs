namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Lysapsus;

/// <summary>
/// Interface defining characteristics of Lysapsus (genus).
/// </summary>
public interface ILysapsus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
