namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Capensibufo;

/// <summary>
/// Interface defining characteristics of Capensibufo (genus).
/// </summary>
public interface ICapensibufo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
