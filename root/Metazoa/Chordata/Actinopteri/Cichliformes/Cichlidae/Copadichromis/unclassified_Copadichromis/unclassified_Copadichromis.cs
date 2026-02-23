using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Copadichromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Copadichromis.unclassified_Copadichromis;

/// <summary>
/// Abstract class for unclassified Copadichromis (no rank).
/// NCBI TaxId: 2625545
/// </summary>
public abstract class unclassified_Copadichromis : Copadichromis, Iunclassified_Copadichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Copadichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625545;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Copadichromis";
}
