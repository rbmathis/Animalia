namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Derichthyidae.Derichthys;

/// <summary>
/// Interface defining characteristics of Derichthys (genus).
/// </summary>
public interface IDerichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
