namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae.Petropedetes;

/// <summary>
/// Interface defining characteristics of Petropedetes (genus).
/// </summary>
public interface IPetropedetes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
