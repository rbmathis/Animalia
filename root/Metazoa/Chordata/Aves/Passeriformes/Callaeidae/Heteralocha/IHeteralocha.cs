namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae.Heteralocha;

/// <summary>
/// Interface defining characteristics of Heteralocha (genus).
/// </summary>
public interface IHeteralocha
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
