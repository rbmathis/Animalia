using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Brachypterois;

/// <summary>
/// Abstract class for Brachypterois (genus).
/// NCBI TaxId: 1188031
/// </summary>
public abstract class Brachypterois : Scorpaenidae, IBrachypterois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachypterois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1188031;

    /// <inheritdoc />
    public virtual string GenusName => "Brachypterois";

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
