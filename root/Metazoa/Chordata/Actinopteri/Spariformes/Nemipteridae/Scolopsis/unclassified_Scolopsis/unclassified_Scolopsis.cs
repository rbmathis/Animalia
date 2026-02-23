using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Scolopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Scolopsis.unclassified_Scolopsis;

/// <summary>
/// Abstract class for unclassified Scolopsis (no rank).
/// NCBI TaxId: 2645012
/// </summary>
public abstract class unclassified_Scolopsis : Scolopsis, Iunclassified_Scolopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scolopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645012;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scolopsis";
}
