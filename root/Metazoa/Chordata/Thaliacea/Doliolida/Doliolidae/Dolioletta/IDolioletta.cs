namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.Dolioletta;

/// <summary>
/// Interface defining characteristics of Dolioletta (genus).
/// </summary>
public interface IDolioletta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
