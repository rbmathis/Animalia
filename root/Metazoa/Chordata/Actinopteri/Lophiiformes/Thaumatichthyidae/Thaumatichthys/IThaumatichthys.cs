namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae.Thaumatichthys;

/// <summary>
/// Interface defining characteristics of Thaumatichthys (genus).
/// </summary>
public interface IThaumatichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
