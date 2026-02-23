namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Dinotopterus;

/// <summary>
/// Interface defining characteristics of Dinotopterus (genus).
/// </summary>
public interface IDinotopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
