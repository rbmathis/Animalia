using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Neoplecostominae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Neoplecostominae.Neoplecostominae_gen_2_CAC_2010;

/// <summary>
/// Abstract class for Neoplecostominae gen. 2 CAC-2010 (genus).
/// NCBI TaxId: 745522
/// </summary>
public abstract class Neoplecostominae_gen_2_CAC_2010 : unclassified_Neoplecostominae, INeoplecostominae_gen_2_CAC_2010
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoplecostominae gen. 2 CAC-2010";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745522;

    /// <inheritdoc />
    public virtual string GenusName => "Neoplecostominae_gen_2_CAC_2010";

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
