namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Characidium;

/// <summary>
/// Interface defining characteristics of Characidium (genus).
/// </summary>
public interface ICharacidium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
