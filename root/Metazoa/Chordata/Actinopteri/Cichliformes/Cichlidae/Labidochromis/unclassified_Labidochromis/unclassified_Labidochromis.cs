using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Labidochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Labidochromis.unclassified_Labidochromis;

/// <summary>
/// Abstract class for unclassified Labidochromis (no rank).
/// NCBI TaxId: 2627174
/// </summary>
public abstract class unclassified_Labidochromis : Labidochromis, Iunclassified_Labidochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labidochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627174;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labidochromis";
}
