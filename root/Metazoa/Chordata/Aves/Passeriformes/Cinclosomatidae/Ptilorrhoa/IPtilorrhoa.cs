namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Ptilorrhoa;

/// <summary>
/// Interface defining characteristics of Ptilorrhoa (genus).
/// </summary>
public interface IPtilorrhoa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
