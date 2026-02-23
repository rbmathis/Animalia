namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Chlamydoselachidae.Chlamydoselachus;

/// <summary>
/// Interface defining characteristics of Chlamydoselachus (genus).
/// </summary>
public interface IChlamydoselachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
