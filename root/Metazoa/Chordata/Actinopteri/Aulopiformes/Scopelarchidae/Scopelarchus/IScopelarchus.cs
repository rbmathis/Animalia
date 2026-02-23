namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Scopelarchus;

/// <summary>
/// Interface defining characteristics of Scopelarchus (genus).
/// </summary>
public interface IScopelarchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
