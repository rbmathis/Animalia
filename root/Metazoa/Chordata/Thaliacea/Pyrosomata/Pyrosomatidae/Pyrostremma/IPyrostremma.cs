namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrostremma;

/// <summary>
/// Interface defining characteristics of Pyrostremma (genus).
/// </summary>
public interface IPyrostremma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
