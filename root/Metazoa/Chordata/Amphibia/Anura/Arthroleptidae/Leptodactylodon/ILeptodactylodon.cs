namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Leptodactylodon;

/// <summary>
/// Interface defining characteristics of Leptodactylodon (genus).
/// </summary>
public interface ILeptodactylodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
