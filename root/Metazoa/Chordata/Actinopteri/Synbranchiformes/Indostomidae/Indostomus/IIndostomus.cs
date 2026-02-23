namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Indostomidae.Indostomus;

/// <summary>
/// Interface defining characteristics of Indostomus (genus).
/// </summary>
public interface IIndostomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
