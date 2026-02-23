using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Nothobranchius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Nothobranchius.unclassified_Nothobranchius;

/// <summary>
/// Abstract class for unclassified Nothobranchius (no rank).
/// NCBI TaxId: 2640750
/// </summary>
public abstract class unclassified_Nothobranchius : Nothobranchius, Iunclassified_Nothobranchius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nothobranchius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640750;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nothobranchius";
}
