namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Brachaeluridae.Brachaelurus;

/// <summary>
/// Interface defining characteristics of Brachaelurus (genus).
/// </summary>
public interface IBrachaelurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
