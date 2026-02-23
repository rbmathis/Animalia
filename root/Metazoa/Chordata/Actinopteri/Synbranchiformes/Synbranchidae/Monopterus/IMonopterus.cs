namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Monopterus;

/// <summary>
/// Interface defining characteristics of Monopterus (genus).
/// </summary>
public interface IMonopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
