using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrochromis.unclassified_Petrochromis;

/// <summary>
/// Abstract class for unclassified Petrochromis (no rank).
/// NCBI TaxId: 2648748
/// </summary>
public abstract class unclassified_Petrochromis : Petrochromis, Iunclassified_Petrochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petrochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648748;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petrochromis";
}
