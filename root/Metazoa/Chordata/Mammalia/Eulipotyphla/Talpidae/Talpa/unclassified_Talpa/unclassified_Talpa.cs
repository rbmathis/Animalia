using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Talpa.unclassified_Talpa;

/// <summary>
/// Abstract class for unclassified Talpa (no rank).
/// NCBI TaxId: 2636403
/// </summary>
public abstract class unclassified_Talpa : Talpa, Iunclassified_Talpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Talpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636403;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Talpa";
}
