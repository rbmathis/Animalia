namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Stiphrornis;

/// <summary>
/// Interface defining characteristics of Stiphrornis (genus).
/// </summary>
public interface IStiphrornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
