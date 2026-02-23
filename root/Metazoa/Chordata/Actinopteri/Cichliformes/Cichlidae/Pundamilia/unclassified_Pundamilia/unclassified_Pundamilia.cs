using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pundamilia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pundamilia.unclassified_Pundamilia;

/// <summary>
/// Abstract class for unclassified Pundamilia (no rank).
/// NCBI TaxId: 2625002
/// </summary>
public abstract class unclassified_Pundamilia : Pundamilia, Iunclassified_Pundamilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pundamilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625002;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pundamilia";
}
