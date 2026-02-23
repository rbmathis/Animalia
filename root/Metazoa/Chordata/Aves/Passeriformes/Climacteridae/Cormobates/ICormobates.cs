namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Climacteridae.Cormobates;

/// <summary>
/// Interface defining characteristics of Cormobates (genus).
/// </summary>
public interface ICormobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
