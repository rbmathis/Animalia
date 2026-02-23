using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Pherallodus.unclassified_Pherallodus;

/// <summary>
/// Abstract class for unclassified Pherallodus (no rank).
/// NCBI TaxId: 2634886
/// </summary>
public abstract class unclassified_Pherallodus : Pherallodus, Iunclassified_Pherallodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pherallodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634886;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pherallodus";
}
