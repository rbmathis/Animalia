namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Melopyrrha;

/// <summary>
/// Interface defining characteristics of Melopyrrha (genus).
/// </summary>
public interface IMelopyrrha
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
