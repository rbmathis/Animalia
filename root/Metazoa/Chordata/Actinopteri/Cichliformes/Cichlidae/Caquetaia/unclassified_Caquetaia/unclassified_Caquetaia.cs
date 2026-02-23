using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Caquetaia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Caquetaia.unclassified_Caquetaia;

/// <summary>
/// Abstract class for unclassified Caquetaia (no rank).
/// NCBI TaxId: 2602631
/// </summary>
public abstract class unclassified_Caquetaia : Caquetaia, Iunclassified_Caquetaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caquetaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602631;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caquetaia";
}
