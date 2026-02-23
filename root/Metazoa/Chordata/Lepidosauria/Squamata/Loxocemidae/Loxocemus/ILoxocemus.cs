namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Loxocemidae.Loxocemus;

/// <summary>
/// Interface defining characteristics of Loxocemus (genus).
/// </summary>
public interface ILoxocemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
