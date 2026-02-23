namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Pheugopedius;

/// <summary>
/// Interface defining characteristics of Pheugopedius (genus).
/// </summary>
public interface IPheugopedius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
