namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophichthyidae.Lophichthys;

/// <summary>
/// Interface defining characteristics of Lophichthys (genus).
/// </summary>
public interface ILophichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
