namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Interface defining characteristics of Clarias (genus).
/// </summary>
public interface IClarias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
