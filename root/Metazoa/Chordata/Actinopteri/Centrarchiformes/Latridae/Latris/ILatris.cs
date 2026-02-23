namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Latridae.Latris;

/// <summary>
/// Interface defining characteristics of Latris (genus).
/// </summary>
public interface ILatris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
