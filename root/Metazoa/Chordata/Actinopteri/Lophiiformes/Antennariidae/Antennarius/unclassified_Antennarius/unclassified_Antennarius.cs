using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Antennarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Antennarius.unclassified_Antennarius;

/// <summary>
/// Abstract class for unclassified Antennarius (no rank).
/// NCBI TaxId: 2626259
/// </summary>
public abstract class unclassified_Antennarius : Antennarius, Iunclassified_Antennarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Antennarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626259;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Antennarius";
}
