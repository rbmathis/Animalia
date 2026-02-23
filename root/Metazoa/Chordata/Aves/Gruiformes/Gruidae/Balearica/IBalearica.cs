namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Balearica;

/// <summary>
/// Interface defining characteristics of Balearica (genus).
/// </summary>
public interface IBalearica
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
