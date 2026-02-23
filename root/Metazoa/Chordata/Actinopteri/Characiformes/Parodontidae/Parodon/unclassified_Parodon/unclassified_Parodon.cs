using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Parodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Parodontidae.Parodon.unclassified_Parodon;

/// <summary>
/// Abstract class for unclassified Parodon (no rank).
/// NCBI TaxId: 2621761
/// </summary>
public abstract class unclassified_Parodon : Parodon, Iunclassified_Parodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621761;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parodon";
}
