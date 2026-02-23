namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mohoidae.Moho;

/// <summary>
/// Interface defining characteristics of Moho (genus).
/// </summary>
public interface IMoho
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
