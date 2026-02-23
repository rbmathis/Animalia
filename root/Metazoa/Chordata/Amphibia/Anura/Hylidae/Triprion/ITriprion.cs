namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Triprion;

/// <summary>
/// Interface defining characteristics of Triprion (genus).
/// </summary>
public interface ITriprion
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
