using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Barbulifer;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Barbulifer.unclassified_Barbulifer;

/// <summary>
/// Abstract class for unclassified Barbulifer (no rank).
/// NCBI TaxId: 2620082
/// </summary>
public abstract class unclassified_Barbulifer : Barbulifer, Iunclassified_Barbulifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Barbulifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620082;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Barbulifer";
}
