using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tylochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tylochromis.unclassified_Tylochromis;

/// <summary>
/// Abstract class for unclassified Tylochromis (no rank).
/// NCBI TaxId: 2646324
/// </summary>
public abstract class unclassified_Tylochromis : Tylochromis, Iunclassified_Tylochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tylochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646324;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tylochromis";
}
