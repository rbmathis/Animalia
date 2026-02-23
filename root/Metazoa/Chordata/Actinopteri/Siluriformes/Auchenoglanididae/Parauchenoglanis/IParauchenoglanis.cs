namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Parauchenoglanis;

/// <summary>
/// Interface defining characteristics of Parauchenoglanis (genus).
/// </summary>
public interface IParauchenoglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
