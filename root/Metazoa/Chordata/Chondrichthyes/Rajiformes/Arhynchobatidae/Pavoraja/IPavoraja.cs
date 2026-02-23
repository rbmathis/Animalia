namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Pavoraja;

/// <summary>
/// Interface defining characteristics of Pavoraja (genus).
/// </summary>
public interface IPavoraja
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
