namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Ibidorhyncha;

/// <summary>
/// Interface defining characteristics of Ibidorhyncha (genus).
/// </summary>
public interface IIbidorhyncha
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
