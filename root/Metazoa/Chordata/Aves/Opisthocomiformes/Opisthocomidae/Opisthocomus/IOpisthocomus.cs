namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Opisthocomiformes.Opisthocomidae.Opisthocomus;

/// <summary>
/// Interface defining characteristics of Opisthocomus (genus).
/// </summary>
public interface IOpisthocomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
