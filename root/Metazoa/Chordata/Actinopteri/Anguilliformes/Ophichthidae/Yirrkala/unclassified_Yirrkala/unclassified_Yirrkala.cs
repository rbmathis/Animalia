using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Yirrkala;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Yirrkala.unclassified_Yirrkala;

/// <summary>
/// Abstract class for unclassified Yirrkala (no rank).
/// NCBI TaxId: 2628698
/// </summary>
public abstract class unclassified_Yirrkala : Yirrkala, Iunclassified_Yirrkala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Yirrkala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628698;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Yirrkala";
}
