namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.Doliolum;

/// <summary>
/// Interface defining characteristics of Doliolum (genus).
/// </summary>
public interface IDoliolum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
