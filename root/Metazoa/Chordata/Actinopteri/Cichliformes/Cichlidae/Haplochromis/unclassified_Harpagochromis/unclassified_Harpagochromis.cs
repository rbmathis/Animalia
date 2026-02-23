using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplochromis.unclassified_Harpagochromis;

/// <summary>
/// Abstract class for unclassified Harpagochromis (no rank).
/// NCBI TaxId: 2760283
/// </summary>
public abstract class unclassified_Harpagochromis : Haplochromis, Iunclassified_Harpagochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harpagochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2760283;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harpagochromis";
}
