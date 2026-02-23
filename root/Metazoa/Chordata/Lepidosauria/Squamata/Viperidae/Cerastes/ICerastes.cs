namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Cerastes;

/// <summary>
/// Interface defining characteristics of Cerastes (genus).
/// </summary>
public interface ICerastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
