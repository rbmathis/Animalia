namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Hydrornis;

/// <summary>
/// Interface defining characteristics of Hydrornis (genus).
/// </summary>
public interface IHydrornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
