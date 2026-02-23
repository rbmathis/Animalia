namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Doliolida.Doliolidae.Doliolina;

/// <summary>
/// Interface defining characteristics of Doliolina (genus).
/// </summary>
public interface IDoliolina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
