using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Bathypterois;

/// <summary>
/// Abstract class for Bathypterois (genus).
/// NCBI TaxId: 206091
/// </summary>
public abstract class Bathypterois : Ipnopidae, IBathypterois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathypterois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206091;

    /// <inheritdoc />
    public virtual string GenusName => "Bathypterois";

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
