using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbodes.unclassified_Barbodes;

/// <summary>
/// Abstract class for unclassified Barbodes (no rank).
/// NCBI TaxId: 2633876
/// </summary>
public abstract class unclassified_Barbodes : Barbodes, Iunclassified_Barbodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Barbodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633876;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Barbodes";
}
