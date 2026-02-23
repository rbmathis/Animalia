using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Aphanius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Aphanius.unclassified_Aphanius;

/// <summary>
/// Abstract class for unclassified Aphanius (no rank).
/// NCBI TaxId: 2621231
/// </summary>
public abstract class unclassified_Aphanius : Aphanius, Iunclassified_Aphanius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphanius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621231;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphanius";
}
