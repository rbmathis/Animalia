using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Monomitopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Monomitopus.unclassified_Monomitopus;

/// <summary>
/// Abstract class for unclassified Monomitopus (no rank).
/// NCBI TaxId: 2649751
/// </summary>
public abstract class unclassified_Monomitopus : Monomitopus, Iunclassified_Monomitopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monomitopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649751;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monomitopus";
}
