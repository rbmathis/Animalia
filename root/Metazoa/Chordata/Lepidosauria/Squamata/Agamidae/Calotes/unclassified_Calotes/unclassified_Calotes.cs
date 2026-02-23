using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Calotes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Calotes.unclassified_Calotes;

/// <summary>
/// Abstract class for unclassified Calotes (no rank).
/// NCBI TaxId: 2638305
/// </summary>
public abstract class unclassified_Calotes : Calotes, Iunclassified_Calotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638305;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calotes";
}
