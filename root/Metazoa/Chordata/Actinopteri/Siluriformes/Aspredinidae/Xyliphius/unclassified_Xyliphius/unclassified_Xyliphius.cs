using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Xyliphius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Xyliphius.unclassified_Xyliphius;

/// <summary>
/// Abstract class for unclassified Xyliphius (no rank).
/// NCBI TaxId: 2637385
/// </summary>
public abstract class unclassified_Xyliphius : Xyliphius, Iunclassified_Xyliphius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xyliphius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637385;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xyliphius";
}
