using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Arcos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Arcos.unclassified_Arcos;

/// <summary>
/// Abstract class for unclassified Arcos (no rank).
/// NCBI TaxId: 2631896
/// </summary>
public abstract class unclassified_Arcos : Arcos, Iunclassified_Arcos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arcos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631896;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arcos";
}
