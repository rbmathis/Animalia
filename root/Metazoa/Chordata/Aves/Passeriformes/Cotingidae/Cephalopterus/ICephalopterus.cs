namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Cephalopterus;

/// <summary>
/// Interface defining characteristics of Cephalopterus (genus).
/// </summary>
public interface ICephalopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
