namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percalates;

/// <summary>
/// Interface defining characteristics of Percalates (genus).
/// </summary>
public interface IPercalates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
