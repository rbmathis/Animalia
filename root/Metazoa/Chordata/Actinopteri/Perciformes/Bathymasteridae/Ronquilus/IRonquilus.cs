namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathymasteridae.Ronquilus;

/// <summary>
/// Interface defining characteristics of Ronquilus (genus).
/// </summary>
public interface IRonquilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
