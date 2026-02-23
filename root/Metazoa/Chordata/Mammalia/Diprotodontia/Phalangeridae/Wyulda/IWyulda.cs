namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Wyulda;

/// <summary>
/// Interface defining characteristics of Wyulda (genus).
/// </summary>
public interface IWyulda
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
