namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes.Heterodontidae.Heterodontus;

/// <summary>
/// Interface defining characteristics of Heterodontus (genus).
/// </summary>
public interface IHeterodontus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
