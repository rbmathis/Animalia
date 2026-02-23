namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Caenolestes;

/// <summary>
/// Interface defining characteristics of Caenolestes (genus).
/// </summary>
public interface ICaenolestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
