using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Propherallodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Propherallodus.unclassified_Propherallodus;

/// <summary>
/// Abstract class for unclassified Propherallodus (no rank).
/// NCBI TaxId: 2633423
/// </summary>
public abstract class unclassified_Propherallodus : Propherallodus, Iunclassified_Propherallodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Propherallodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633423;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Propherallodus";
}
