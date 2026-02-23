namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodiscus;

/// <summary>
/// Interface defining characteristics of Pherallodiscus (genus).
/// </summary>
public interface IPherallodiscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
