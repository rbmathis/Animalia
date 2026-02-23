using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Atlantirivulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Atlantirivulus.unclassified_Atlantirivulus;

/// <summary>
/// Abstract class for unclassified Atlantirivulus (no rank).
/// NCBI TaxId: 3141572
/// </summary>
public abstract class unclassified_Atlantirivulus : Atlantirivulus, Iunclassified_Atlantirivulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atlantirivulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3141572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atlantirivulus";
}
