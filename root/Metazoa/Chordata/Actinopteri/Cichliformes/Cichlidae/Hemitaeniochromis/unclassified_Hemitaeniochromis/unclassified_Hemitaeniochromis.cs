using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemitaeniochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemitaeniochromis.unclassified_Hemitaeniochromis;

/// <summary>
/// Abstract class for unclassified Hemitaeniochromis (no rank).
/// NCBI TaxId: 3075805
/// </summary>
public abstract class unclassified_Hemitaeniochromis : Hemitaeniochromis, Iunclassified_Hemitaeniochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemitaeniochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3075805;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemitaeniochromis";
}
