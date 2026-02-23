using AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Asymmetron;

namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Asymmetron.unclassified_Asymmetron;

/// <summary>
/// Abstract class for unclassified Asymmetron (no rank).
/// NCBI TaxId: 2625379
/// </summary>
public abstract class unclassified_Asymmetron : Asymmetron, Iunclassified_Asymmetron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Asymmetron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625379;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Asymmetron";
}
