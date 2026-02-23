namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Trilepida;

/// <summary>
/// Interface defining characteristics of Trilepida (genus).
/// </summary>
public interface ITrilepida
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
