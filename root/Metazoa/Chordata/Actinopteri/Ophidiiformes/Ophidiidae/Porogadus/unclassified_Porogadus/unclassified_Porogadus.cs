using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Porogadus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Porogadus.unclassified_Porogadus;

/// <summary>
/// Abstract class for unclassified Porogadus (no rank).
/// NCBI TaxId: 2638433
/// </summary>
public abstract class unclassified_Porogadus : Porogadus, Iunclassified_Porogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Porogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Porogadus";
}
