using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae.Pachypanchax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae.Pachypanchax.unclassified_Pachypanchax;

/// <summary>
/// Abstract class for unclassified Pachypanchax (no rank).
/// NCBI TaxId: 2949126
/// </summary>
public abstract class unclassified_Pachypanchax : Pachypanchax, Iunclassified_Pachypanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachypanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2949126;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachypanchax";
}
