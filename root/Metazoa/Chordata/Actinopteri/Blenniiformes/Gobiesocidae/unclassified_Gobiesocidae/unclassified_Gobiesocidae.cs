using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.unclassified_Gobiesocidae;

/// <summary>
/// Abstract class for unclassified Gobiesocidae (no rank).
/// NCBI TaxId: 2589247
/// </summary>
public abstract class unclassified_Gobiesocidae : Gobiesocidae, Iunclassified_Gobiesocidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiesocidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2589247;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiesocidae";
}
