namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cynoglossidae.Cynoglossus;

/// <summary>
/// Interface defining characteristics of Cynoglossus (genus).
/// </summary>
public interface ICynoglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
