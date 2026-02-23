namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Lagothrix;

/// <summary>
/// Interface defining characteristics of Lagothrix (genus).
/// </summary>
public interface ILagothrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
