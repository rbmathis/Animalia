using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Placidochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Placidochromis.unclassified_Placidochromis;

/// <summary>
/// Abstract class for unclassified Placidochromis (no rank).
/// NCBI TaxId: 2633042
/// </summary>
public abstract class unclassified_Placidochromis : Placidochromis, Iunclassified_Placidochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Placidochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633042;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Placidochromis";
}
