using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Anotosaura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Anotosaura.unclassified_Anotosaura;

/// <summary>
/// Abstract class for unclassified Anotosaura (no rank).
/// NCBI TaxId: 2638395
/// </summary>
public abstract class unclassified_Anotosaura : Anotosaura, Iunclassified_Anotosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anotosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638395;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anotosaura";
}
