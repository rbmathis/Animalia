namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Malindangia;

/// <summary>
/// Interface defining characteristics of Malindangia (genus).
/// </summary>
public interface IMalindangia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
