namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Apalis;

/// <summary>
/// Interface defining characteristics of Apalis (genus).
/// </summary>
public interface IApalis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
