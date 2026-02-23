namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Viduidae.Vidua;

/// <summary>
/// Interface defining characteristics of Vidua (genus).
/// </summary>
public interface IVidua
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
