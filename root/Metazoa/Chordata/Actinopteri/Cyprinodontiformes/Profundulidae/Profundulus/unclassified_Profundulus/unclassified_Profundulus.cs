using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae.Profundulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae.Profundulus.unclassified_Profundulus;

/// <summary>
/// Abstract class for unclassified Profundulus (no rank).
/// NCBI TaxId: 2622803
/// </summary>
public abstract class unclassified_Profundulus : Profundulus, Iunclassified_Profundulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Profundulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622803;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Profundulus";
}
