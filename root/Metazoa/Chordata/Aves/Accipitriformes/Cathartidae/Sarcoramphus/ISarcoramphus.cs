namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae.Sarcoramphus;

/// <summary>
/// Interface defining characteristics of Sarcoramphus (genus).
/// </summary>
public interface ISarcoramphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
