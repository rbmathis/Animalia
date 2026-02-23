using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemichromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemichromis.unclassified_Hemichromis;

/// <summary>
/// Abstract class for unclassified Hemichromis (no rank).
/// NCBI TaxId: 2641562
/// </summary>
public abstract class unclassified_Hemichromis : Hemichromis, Iunclassified_Hemichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641562;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemichromis";
}
