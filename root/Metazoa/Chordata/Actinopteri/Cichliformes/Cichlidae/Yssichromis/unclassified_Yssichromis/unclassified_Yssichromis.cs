using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Yssichromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Yssichromis.unclassified_Yssichromis;

/// <summary>
/// Abstract class for unclassified Yssichromis (no rank).
/// NCBI TaxId: 2766845
/// </summary>
public abstract class unclassified_Yssichromis : Yssichromis, Iunclassified_Yssichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Yssichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2766845;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Yssichromis";
}
