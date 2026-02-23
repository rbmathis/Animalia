namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Craterognathus;

/// <summary>
/// Interface defining characteristics of Craterognathus (genus).
/// </summary>
public interface ICraterognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
