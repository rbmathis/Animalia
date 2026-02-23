using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.unclassified_Motacillidae;

/// <summary>
/// Abstract class for unclassified Motacillidae (no rank).
/// NCBI TaxId: 2419794
/// </summary>
public abstract class unclassified_Motacillidae : Motacillidae, Iunclassified_Motacillidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Motacillidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2419794;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Motacillidae";
}
