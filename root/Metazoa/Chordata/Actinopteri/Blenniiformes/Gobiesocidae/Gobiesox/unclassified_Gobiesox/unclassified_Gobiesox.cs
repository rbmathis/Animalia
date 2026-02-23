using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gobiesox;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gobiesox.unclassified_Gobiesox;

/// <summary>
/// Abstract class for unclassified Gobiesox (no rank).
/// NCBI TaxId: 2647232
/// </summary>
public abstract class unclassified_Gobiesox : Gobiesox, Iunclassified_Gobiesox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiesox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647232;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiesox";
}
