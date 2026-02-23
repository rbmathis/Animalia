using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Nuchequula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Nuchequula.unclassified_Nuchequula;

/// <summary>
/// Abstract class for unclassified Nuchequula (no rank).
/// NCBI TaxId: 2642067
/// </summary>
public abstract class unclassified_Nuchequula : Nuchequula, Iunclassified_Nuchequula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nuchequula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642067;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nuchequula";
}
