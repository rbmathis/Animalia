namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae.Corella;

/// <summary>
/// Interface defining characteristics of Corella (genus).
/// </summary>
public interface ICorella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
