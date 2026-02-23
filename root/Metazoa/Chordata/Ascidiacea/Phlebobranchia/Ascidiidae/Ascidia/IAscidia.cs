namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Ascidia;

/// <summary>
/// Interface defining characteristics of Ascidia (genus).
/// </summary>
public interface IAscidia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
