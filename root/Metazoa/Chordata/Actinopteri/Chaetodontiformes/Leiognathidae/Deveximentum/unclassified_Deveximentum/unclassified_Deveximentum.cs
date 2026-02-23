using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Deveximentum;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Deveximentum.unclassified_Deveximentum;

/// <summary>
/// Abstract class for unclassified Deveximentum (no rank).
/// NCBI TaxId: 2685793
/// </summary>
public abstract class unclassified_Deveximentum : Deveximentum, Iunclassified_Deveximentum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Deveximentum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685793;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Deveximentum";
}
