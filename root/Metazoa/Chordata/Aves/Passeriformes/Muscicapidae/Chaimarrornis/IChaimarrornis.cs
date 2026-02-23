namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Chaimarrornis;

/// <summary>
/// Interface defining characteristics of Chaimarrornis (genus).
/// </summary>
public interface IChaimarrornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
