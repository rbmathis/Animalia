namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Artisornis;

/// <summary>
/// Interface defining characteristics of Artisornis (genus).
/// </summary>
public interface IArtisornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
