using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Pastinachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Pastinachus.unclassified_Pastinachus;

/// <summary>
/// Abstract class for unclassified Pastinachus (no rank).
/// NCBI TaxId: 2624310
/// </summary>
public abstract class unclassified_Pastinachus : Pastinachus, Iunclassified_Pastinachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pastinachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624310;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pastinachus";
}
