using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nanochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nanochromis.unclassified_Nanochromis;

/// <summary>
/// Abstract class for unclassified Nanochromis (no rank).
/// NCBI TaxId: 2637997
/// </summary>
public abstract class unclassified_Nanochromis : Nanochromis, Iunclassified_Nanochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nanochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637997;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nanochromis";
}
