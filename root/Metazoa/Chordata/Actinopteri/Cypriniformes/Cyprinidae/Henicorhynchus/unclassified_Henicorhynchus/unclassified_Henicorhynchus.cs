using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Henicorhynchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Henicorhynchus.unclassified_Henicorhynchus;

/// <summary>
/// Abstract class for unclassified Henicorhynchus (no rank).
/// NCBI TaxId: 2677337
/// </summary>
public abstract class unclassified_Henicorhynchus : Henicorhynchus, Iunclassified_Henicorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Henicorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677337;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Henicorhynchus";
}
