namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae.Zachaenus;

/// <summary>
/// Interface defining characteristics of Zachaenus (genus).
/// </summary>
public interface IZachaenus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
