using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nyassachromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nyassachromis.unclassified_Nyassachromis;

/// <summary>
/// Abstract class for unclassified Nyassachromis (no rank).
/// NCBI TaxId: 2685397
/// </summary>
public abstract class unclassified_Nyassachromis : Nyassachromis, Iunclassified_Nyassachromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyassachromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685397;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyassachromis";
}
