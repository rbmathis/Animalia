using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Eubleekeria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Eubleekeria.unclassified_Eubleekeria;

/// <summary>
/// Abstract class for unclassified Eubleekeria (no rank).
/// NCBI TaxId: 3051876
/// </summary>
public abstract class unclassified_Eubleekeria : Eubleekeria, Iunclassified_Eubleekeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eubleekeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051876;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eubleekeria";
}
