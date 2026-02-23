namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Batrachostomatidae.Batrachostomus;

/// <summary>
/// Interface defining characteristics of Batrachostomus (genus).
/// </summary>
public interface IBatrachostomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
