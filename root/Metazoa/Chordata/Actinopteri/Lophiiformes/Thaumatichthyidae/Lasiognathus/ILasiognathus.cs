namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae.Lasiognathus;

/// <summary>
/// Interface defining characteristics of Lasiognathus (genus).
/// </summary>
public interface ILasiognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
