using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Thorius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Thorius.unclassified_Thorius;

/// <summary>
/// Abstract class for unclassified Thorius (no rank).
/// NCBI TaxId: 2634880
/// </summary>
public abstract class unclassified_Thorius : Thorius, Iunclassified_Thorius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thorius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634880;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thorius";
}
