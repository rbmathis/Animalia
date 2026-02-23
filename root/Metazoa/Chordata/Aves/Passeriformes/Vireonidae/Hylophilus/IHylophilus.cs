namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Hylophilus;

/// <summary>
/// Interface defining characteristics of Hylophilus (genus).
/// </summary>
public interface IHylophilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
