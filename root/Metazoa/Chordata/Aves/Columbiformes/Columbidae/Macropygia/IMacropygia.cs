namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Macropygia;

/// <summary>
/// Interface defining characteristics of Macropygia (genus).
/// </summary>
public interface IMacropygia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
