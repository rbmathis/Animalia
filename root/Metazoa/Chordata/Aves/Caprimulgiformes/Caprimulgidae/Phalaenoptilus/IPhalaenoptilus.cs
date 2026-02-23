namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Phalaenoptilus;

/// <summary>
/// Interface defining characteristics of Phalaenoptilus (genus).
/// </summary>
public interface IPhalaenoptilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
