namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Alytes;

/// <summary>
/// Interface defining characteristics of Alytes (genus).
/// </summary>
public interface IAlytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
