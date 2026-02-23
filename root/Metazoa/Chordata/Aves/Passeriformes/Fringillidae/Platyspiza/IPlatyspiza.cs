namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Platyspiza;

/// <summary>
/// Interface defining characteristics of Platyspiza (genus).
/// </summary>
public interface IPlatyspiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
