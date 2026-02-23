using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Sanopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Sanopus.unclassified_Sanopus;

/// <summary>
/// Abstract class for unclassified Sanopus (no rank).
/// NCBI TaxId: 2646547
/// </summary>
public abstract class unclassified_Sanopus : Sanopus, Iunclassified_Sanopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sanopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646547;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sanopus";
}
