namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae.Arthroleptides;

/// <summary>
/// Interface defining characteristics of Arthroleptides (genus).
/// </summary>
public interface IArthroleptides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
