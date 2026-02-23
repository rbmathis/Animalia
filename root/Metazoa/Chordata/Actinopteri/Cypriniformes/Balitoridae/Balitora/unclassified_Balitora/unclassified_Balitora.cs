using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Balitora;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Balitora.unclassified_Balitora;

/// <summary>
/// Abstract class for unclassified Balitora (no rank).
/// NCBI TaxId: 2620409
/// </summary>
public abstract class unclassified_Balitora : Balitora, Iunclassified_Balitora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Balitora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620409;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Balitora";
}
