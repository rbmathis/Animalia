namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Puffinus;

/// <summary>
/// Interface defining characteristics of Puffinus (genus).
/// </summary>
public interface IPuffinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
