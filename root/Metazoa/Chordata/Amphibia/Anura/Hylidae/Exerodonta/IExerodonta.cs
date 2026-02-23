namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Exerodonta;

/// <summary>
/// Interface defining characteristics of Exerodonta (genus).
/// </summary>
public interface IExerodonta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
