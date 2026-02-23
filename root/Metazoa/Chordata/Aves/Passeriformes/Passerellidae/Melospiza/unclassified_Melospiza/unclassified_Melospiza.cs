using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Melospiza;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Melospiza.unclassified_Melospiza;

/// <summary>
/// Abstract class for unclassified Melospiza (no rank).
/// NCBI TaxId: 2878403
/// </summary>
public abstract class unclassified_Melospiza : Melospiza, Iunclassified_Melospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878403;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melospiza";
}
