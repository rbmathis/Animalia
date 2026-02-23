namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Synanceiidae_incertae_sedis.Erosa;

/// <summary>
/// Interface defining characteristics of Erosa (genus).
/// </summary>
public interface IErosa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
