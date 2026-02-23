using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Cercosaura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Cercosaura.unclassified_Cercosaura;

/// <summary>
/// Abstract class for unclassified Cercosaura (no rank).
/// NCBI TaxId: 2621159
/// </summary>
public abstract class unclassified_Cercosaura : Cercosaura, Iunclassified_Cercosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cercosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621159;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cercosaura";
}
