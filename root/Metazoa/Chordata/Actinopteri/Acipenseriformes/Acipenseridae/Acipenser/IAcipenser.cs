namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Interface defining characteristics of Acipenser (genus).
/// </summary>
public interface IAcipenser
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
