namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Kenyaphrynoides;

/// <summary>
/// Interface defining characteristics of Kenyaphrynoides (genus).
/// </summary>
public interface IKenyaphrynoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
