using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kuhliidae.Kuhlia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kuhliidae.Kuhlia.unclassified_Kuhlia;

/// <summary>
/// Abstract class for unclassified Kuhlia (no rank).
/// NCBI TaxId: 3230566
/// </summary>
public abstract class unclassified_Kuhlia : Kuhlia, Iunclassified_Kuhlia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kuhlia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3230566;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kuhlia";
}
