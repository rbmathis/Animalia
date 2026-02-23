namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Cuon;

/// <summary>
/// Interface defining characteristics of Cuon (genus).
/// </summary>
public interface ICuon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
