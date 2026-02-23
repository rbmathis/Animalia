using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Sundadanionidae.Sundadanio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Sundadanionidae.Sundadanio.unclassified_Sundadanio;

/// <summary>
/// Abstract class for unclassified Sundadanio (no rank).
/// NCBI TaxId: 2646742
/// </summary>
public abstract class unclassified_Sundadanio : Sundadanio, Iunclassified_Sundadanio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sundadanio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646742;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sundadanio";
}
