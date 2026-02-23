using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Stiphodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Stiphodon.unclassified_Stiphodon;

/// <summary>
/// Abstract class for unclassified Stiphodon (no rank).
/// NCBI TaxId: 2628230
/// </summary>
public abstract class unclassified_Stiphodon : Stiphodon, Iunclassified_Stiphodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stiphodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628230;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stiphodon";
}
