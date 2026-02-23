namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Pycnoptilus;

/// <summary>
/// Interface defining characteristics of Pycnoptilus (genus).
/// </summary>
public interface IPycnoptilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
