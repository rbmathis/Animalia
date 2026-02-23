using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix.unclassified_Strix;

/// <summary>
/// Abstract class for unclassified Strix (no rank).
/// NCBI TaxId: 2878430
/// </summary>
public abstract class unclassified_Strix : Strix, Iunclassified_Strix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Strix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878430;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Strix";
}
