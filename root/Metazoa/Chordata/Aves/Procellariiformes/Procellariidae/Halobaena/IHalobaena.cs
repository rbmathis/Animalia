namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Halobaena;

/// <summary>
/// Interface defining characteristics of Halobaena (genus).
/// </summary>
public interface IHalobaena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
