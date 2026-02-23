namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Anchariidae.Gogo;

/// <summary>
/// Interface defining characteristics of Gogo (genus).
/// </summary>
public interface IGogo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
