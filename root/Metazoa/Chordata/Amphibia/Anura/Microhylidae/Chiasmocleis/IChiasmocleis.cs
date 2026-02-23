namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Chiasmocleis;

/// <summary>
/// Interface defining characteristics of Chiasmocleis (genus).
/// </summary>
public interface IChiasmocleis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
