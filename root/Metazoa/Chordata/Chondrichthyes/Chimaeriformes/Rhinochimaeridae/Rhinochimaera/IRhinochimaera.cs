namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae.Rhinochimaera;

/// <summary>
/// Interface defining characteristics of Rhinochimaera (genus).
/// </summary>
public interface IRhinochimaera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
