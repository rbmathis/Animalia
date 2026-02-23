namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Argentinidae.Glossanodon;

/// <summary>
/// Interface defining characteristics of Glossanodon (genus).
/// </summary>
public interface IGlossanodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
