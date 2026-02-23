namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Megaelosia;

/// <summary>
/// Interface defining characteristics of Megaelosia (genus).
/// </summary>
public interface IMegaelosia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
