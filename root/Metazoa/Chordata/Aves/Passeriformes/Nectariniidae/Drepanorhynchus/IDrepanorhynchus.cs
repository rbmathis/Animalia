namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Drepanorhynchus;

/// <summary>
/// Interface defining characteristics of Drepanorhynchus (genus).
/// </summary>
public interface IDrepanorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
