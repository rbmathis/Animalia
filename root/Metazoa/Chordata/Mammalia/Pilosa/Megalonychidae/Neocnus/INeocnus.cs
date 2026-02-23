namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae.Neocnus;

/// <summary>
/// Interface defining characteristics of Neocnus (genus).
/// </summary>
public interface INeocnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
