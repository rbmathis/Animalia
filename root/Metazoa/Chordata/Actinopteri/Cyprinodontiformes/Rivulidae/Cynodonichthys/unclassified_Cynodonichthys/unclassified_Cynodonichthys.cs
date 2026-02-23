using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Cynodonichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Cynodonichthys.unclassified_Cynodonichthys;

/// <summary>
/// Abstract class for unclassified Cynodonichthys (no rank).
/// NCBI TaxId: 3110875
/// </summary>
public abstract class unclassified_Cynodonichthys : Cynodonichthys, Iunclassified_Cynodonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynodonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3110875;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynodonichthys";
}
