namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Tathicarpus;

/// <summary>
/// Interface defining characteristics of Tathicarpus (genus).
/// </summary>
public interface ITathicarpus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
