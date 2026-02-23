namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Lophotis;

/// <summary>
/// Interface defining characteristics of Lophotis (genus).
/// </summary>
public interface ILophotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
