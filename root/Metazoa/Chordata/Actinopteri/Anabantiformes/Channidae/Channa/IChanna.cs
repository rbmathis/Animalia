namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Channa;

/// <summary>
/// Interface defining characteristics of Channa (genus).
/// </summary>
public interface IChanna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
