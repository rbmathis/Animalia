using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Leptodeira;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Leptodeira.unclassified_Leptodeira;

/// <summary>
/// Abstract class for unclassified Leptodeira (no rank).
/// NCBI TaxId: 2813973
/// </summary>
public abstract class unclassified_Leptodeira : Leptodeira, Iunclassified_Leptodeira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptodeira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2813973;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptodeira";
}
