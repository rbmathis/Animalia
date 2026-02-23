using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Neoplecostominae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Neoplecostominae.Neoplecostominae_gen_2_FFR_2012;

/// <summary>
/// Abstract class for Neoplecostominae gen. 2 FFR-2012 (genus).
/// NCBI TaxId: 1191586
/// </summary>
public abstract class Neoplecostominae_gen_2_FFR_2012 : unclassified_Neoplecostominae, INeoplecostominae_gen_2_FFR_2012
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoplecostominae gen. 2 FFR-2012";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1191586;

    /// <inheritdoc />
    public virtual string GenusName => "Neoplecostominae_gen_2_FFR_2012";

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
