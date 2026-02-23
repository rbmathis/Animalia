namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Caiman;

/// <summary>
/// Interface defining characteristics of Caiman (genus).
/// </summary>
public interface ICaiman
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
