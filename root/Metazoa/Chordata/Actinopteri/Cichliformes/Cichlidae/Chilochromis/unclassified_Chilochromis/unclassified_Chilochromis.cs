using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chilochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chilochromis.unclassified_Chilochromis;

/// <summary>
/// Abstract class for unclassified Chilochromis (no rank).
/// NCBI TaxId: 2626925
/// </summary>
public abstract class unclassified_Chilochromis : Chilochromis, Iunclassified_Chilochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chilochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chilochromis";
}
