namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Asarcornis;

/// <summary>
/// Interface defining characteristics of Asarcornis (genus).
/// </summary>
public interface IAsarcornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
