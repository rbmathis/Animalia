using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Schizodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Schizodon.unclassified_Schizodon;

/// <summary>
/// Abstract class for unclassified Schizodon (no rank).
/// NCBI TaxId: 2628615
/// </summary>
public abstract class unclassified_Schizodon : Schizodon, Iunclassified_Schizodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schizodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628615;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schizodon";
}
