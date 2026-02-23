namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Micropygia;

/// <summary>
/// Interface defining characteristics of Micropygia (genus).
/// </summary>
public interface IMicropygia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
