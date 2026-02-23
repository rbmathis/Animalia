namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Fimbrora;

/// <summary>
/// Interface defining characteristics of Fimbrora (genus).
/// </summary>
public interface IFimbrora
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
