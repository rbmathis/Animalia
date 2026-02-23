namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Blythophryne;

/// <summary>
/// Interface defining characteristics of Blythophryne (genus).
/// </summary>
public interface IBlythophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
