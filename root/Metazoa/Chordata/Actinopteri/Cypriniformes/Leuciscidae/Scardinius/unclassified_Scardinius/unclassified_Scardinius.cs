using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Scardinius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Scardinius.unclassified_Scardinius;

/// <summary>
/// Abstract class for unclassified Scardinius (no rank).
/// NCBI TaxId: 3472377
/// </summary>
public abstract class unclassified_Scardinius : Scardinius, Iunclassified_Scardinius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scardinius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3472377;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scardinius";
}
