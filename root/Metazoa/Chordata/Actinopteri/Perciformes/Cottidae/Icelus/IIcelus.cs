namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Icelus;

/// <summary>
/// Interface defining characteristics of Icelus (genus).
/// </summary>
public interface IIcelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
