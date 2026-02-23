using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Leiognathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Leiognathus.unclassified_Leiognathus;

/// <summary>
/// Abstract class for unclassified Leiognathus (no rank).
/// NCBI TaxId: 2620570
/// </summary>
public abstract class unclassified_Leiognathus : Leiognathus, Iunclassified_Leiognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leiognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620570;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leiognathus";
}
