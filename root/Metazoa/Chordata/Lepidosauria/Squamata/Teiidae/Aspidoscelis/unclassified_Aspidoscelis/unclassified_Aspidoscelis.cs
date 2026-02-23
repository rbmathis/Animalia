using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis.unclassified_Aspidoscelis;

/// <summary>
/// Abstract class for unclassified Aspidoscelis (no rank).
/// NCBI TaxId: 2817069
/// </summary>
public abstract class unclassified_Aspidoscelis : Aspidoscelis, Iunclassified_Aspidoscelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aspidoscelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2817069;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aspidoscelis";
}
