using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Bubo;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Bubo.unclassified_Bubo;

/// <summary>
/// Abstract class for unclassified Bubo (no rank).
/// NCBI TaxId: 2648367
/// </summary>
public abstract class unclassified_Bubo : Bubo, Iunclassified_Bubo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bubo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648367;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bubo";
}
