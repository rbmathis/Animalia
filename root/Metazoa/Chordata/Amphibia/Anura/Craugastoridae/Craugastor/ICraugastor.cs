namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Interface defining characteristics of Craugastor (genus).
/// </summary>
public interface ICraugastor
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
