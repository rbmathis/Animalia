using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mylochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mylochromis.unclassified_Mylochromis;

/// <summary>
/// Abstract class for unclassified Mylochromis (no rank).
/// NCBI TaxId: 2637418
/// </summary>
public abstract class unclassified_Mylochromis : Mylochromis, Iunclassified_Mylochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mylochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637418;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mylochromis";
}
