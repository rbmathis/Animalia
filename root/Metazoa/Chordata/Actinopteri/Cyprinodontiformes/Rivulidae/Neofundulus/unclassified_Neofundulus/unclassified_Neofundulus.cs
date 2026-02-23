using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Neofundulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Neofundulus.unclassified_Neofundulus;

/// <summary>
/// Abstract class for unclassified Neofundulus (no rank).
/// NCBI TaxId: 2640480
/// </summary>
public abstract class unclassified_Neofundulus : Neofundulus, Iunclassified_Neofundulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neofundulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640480;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neofundulus";
}
