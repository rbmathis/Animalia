using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Grammistops;

/// <summary>
/// Abstract class for Grammistops (genus).
/// NCBI TaxId: 1156470
/// </summary>
public abstract class Grammistops : Serranidae, IGrammistops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammistops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156470;

    /// <inheritdoc />
    public virtual string GenusName => "Grammistops";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
