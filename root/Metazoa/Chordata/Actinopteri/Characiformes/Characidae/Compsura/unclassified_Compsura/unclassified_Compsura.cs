using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Compsura;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Compsura.unclassified_Compsura;

/// <summary>
/// Abstract class for unclassified Compsura (no rank).
/// NCBI TaxId: 2624440
/// </summary>
public abstract class unclassified_Compsura : Compsura, Iunclassified_Compsura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Compsura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624440;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Compsura";
}
