namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Minous;

/// <summary>
/// Interface defining characteristics of Minous (genus).
/// </summary>
public interface IMinous
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
