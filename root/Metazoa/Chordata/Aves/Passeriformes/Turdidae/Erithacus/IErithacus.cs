namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Erithacus;

/// <summary>
/// Interface defining characteristics of Erithacus (genus).
/// </summary>
public interface IErithacus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
