namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Gymnomystax;

/// <summary>
/// Interface defining characteristics of Gymnomystax (genus).
/// </summary>
public interface IGymnomystax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
