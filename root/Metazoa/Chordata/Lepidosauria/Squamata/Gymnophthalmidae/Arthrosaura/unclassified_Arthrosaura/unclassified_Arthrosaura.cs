using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Arthrosaura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Arthrosaura.unclassified_Arthrosaura;

/// <summary>
/// Abstract class for unclassified Arthrosaura (no rank).
/// NCBI TaxId: 2627055
/// </summary>
public abstract class unclassified_Arthrosaura : Arthrosaura, Iunclassified_Arthrosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arthrosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627055;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arthrosaura";
}
