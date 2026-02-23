namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Rhynchostruthus;

/// <summary>
/// Interface defining characteristics of Rhynchostruthus (genus).
/// </summary>
public interface IRhynchostruthus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
