namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Prophagorus;

/// <summary>
/// Interface defining characteristics of Prophagorus (genus).
/// </summary>
public interface IProphagorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
