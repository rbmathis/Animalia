using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae.Pliotrema;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae.Pliotrema.unclassified_Pliotrema;

/// <summary>
/// Abstract class for unclassified Pliotrema (no rank).
/// NCBI TaxId: 2715527
/// </summary>
public abstract class unclassified_Pliotrema : Pliotrema, Iunclassified_Pliotrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pliotrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2715527;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pliotrema";
}
