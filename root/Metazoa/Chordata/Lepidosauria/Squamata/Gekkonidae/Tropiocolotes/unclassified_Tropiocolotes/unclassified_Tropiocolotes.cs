using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Tropiocolotes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Tropiocolotes.unclassified_Tropiocolotes;

/// <summary>
/// Abstract class for unclassified Tropiocolotes (no rank).
/// NCBI TaxId: 2635901
/// </summary>
public abstract class unclassified_Tropiocolotes : Tropiocolotes, Iunclassified_Tropiocolotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tropiocolotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635901;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tropiocolotes";
}
