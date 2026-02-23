namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Nomonyx;

/// <summary>
/// Interface defining characteristics of Nomonyx (genus).
/// </summary>
public interface INomonyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
