namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Diazonidae.Rhopalaea;

/// <summary>
/// Interface defining characteristics of Rhopalaea (genus).
/// </summary>
public interface IRhopalaea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
