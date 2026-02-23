using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Aurigequula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Aurigequula.unclassified_Aurigequula;

/// <summary>
/// Abstract class for unclassified Aurigequula (no rank).
/// NCBI TaxId: 2617951
/// </summary>
public abstract class unclassified_Aurigequula : Aurigequula, Iunclassified_Aurigequula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aurigequula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617951;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aurigequula";
}
