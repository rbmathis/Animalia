namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Tigriornis;

/// <summary>
/// Interface defining characteristics of Tigriornis (genus).
/// </summary>
public interface ITigriornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
