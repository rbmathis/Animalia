namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Distaplia;

/// <summary>
/// Interface defining characteristics of Distaplia (genus).
/// </summary>
public interface IDistaplia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
