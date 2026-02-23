namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Solenostomidae.Solenostomus;

/// <summary>
/// Interface defining characteristics of Solenostomus (genus).
/// </summary>
public interface ISolenostomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
