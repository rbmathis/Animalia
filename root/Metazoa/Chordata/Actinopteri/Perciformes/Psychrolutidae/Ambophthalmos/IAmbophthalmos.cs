namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Ambophthalmos;

/// <summary>
/// Interface defining characteristics of Ambophthalmos (genus).
/// </summary>
public interface IAmbophthalmos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
