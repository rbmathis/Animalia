using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Danakilia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Danakilia.unclassified_Danakilia;

/// <summary>
/// Abstract class for unclassified Danakilia (no rank).
/// NCBI TaxId: 2639749
/// </summary>
public abstract class unclassified_Danakilia : Danakilia, Iunclassified_Danakilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Danakilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639749;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Danakilia";
}
