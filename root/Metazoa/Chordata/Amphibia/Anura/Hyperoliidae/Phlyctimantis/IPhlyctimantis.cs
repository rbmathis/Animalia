namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Phlyctimantis;

/// <summary>
/// Interface defining characteristics of Phlyctimantis (genus).
/// </summary>
public interface IPhlyctimantis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
