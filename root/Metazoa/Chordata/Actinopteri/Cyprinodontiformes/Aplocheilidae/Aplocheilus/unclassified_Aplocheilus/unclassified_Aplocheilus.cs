using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae.Aplocheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aplocheilidae.Aplocheilus.unclassified_Aplocheilus;

/// <summary>
/// Abstract class for unclassified Aplocheilus (no rank).
/// NCBI TaxId: 2630285
/// </summary>
public abstract class unclassified_Aplocheilus : Aplocheilus, Iunclassified_Aplocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aplocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630285;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aplocheilus";
}
