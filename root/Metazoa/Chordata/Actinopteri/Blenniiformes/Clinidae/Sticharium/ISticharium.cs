namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Sticharium;

/// <summary>
/// Interface defining characteristics of Sticharium (genus).
/// </summary>
public interface ISticharium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
