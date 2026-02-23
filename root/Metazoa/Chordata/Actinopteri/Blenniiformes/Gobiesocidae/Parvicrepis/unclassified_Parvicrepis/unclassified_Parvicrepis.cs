using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Parvicrepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Parvicrepis.unclassified_Parvicrepis;

/// <summary>
/// Abstract class for unclassified Parvicrepis (no rank).
/// NCBI TaxId: 2740764
/// </summary>
public abstract class unclassified_Parvicrepis : Parvicrepis, Iunclassified_Parvicrepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parvicrepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740764;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parvicrepis";
}
