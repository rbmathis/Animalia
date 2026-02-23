namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Anaspidoglanis;

/// <summary>
/// Interface defining characteristics of Anaspidoglanis (genus).
/// </summary>
public interface IAnaspidoglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
