namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Baeolophus;

/// <summary>
/// Interface defining characteristics of Baeolophus (genus).
/// </summary>
public interface IBaeolophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
