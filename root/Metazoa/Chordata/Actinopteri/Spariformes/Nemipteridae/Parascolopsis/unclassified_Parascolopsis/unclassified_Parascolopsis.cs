using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Parascolopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Parascolopsis.unclassified_Parascolopsis;

/// <summary>
/// Abstract class for unclassified Parascolopsis (no rank).
/// NCBI TaxId: 2631289
/// </summary>
public abstract class unclassified_Parascolopsis : Parascolopsis, Iunclassified_Parascolopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parascolopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631289;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parascolopsis";
}
