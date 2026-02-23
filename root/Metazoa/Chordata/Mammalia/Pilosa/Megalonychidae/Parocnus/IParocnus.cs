namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae.Parocnus;

/// <summary>
/// Interface defining characteristics of Parocnus (genus).
/// </summary>
public interface IParocnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
