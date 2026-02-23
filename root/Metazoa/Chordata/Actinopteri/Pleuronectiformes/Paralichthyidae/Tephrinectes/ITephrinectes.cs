namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Tephrinectes;

/// <summary>
/// Interface defining characteristics of Tephrinectes (genus).
/// </summary>
public interface ITephrinectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
