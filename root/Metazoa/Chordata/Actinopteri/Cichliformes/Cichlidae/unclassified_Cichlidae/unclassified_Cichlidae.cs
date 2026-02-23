using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.unclassified_Cichlidae;

/// <summary>
/// Abstract class for unclassified Cichlidae (no rank).
/// NCBI TaxId: 175426
/// </summary>
public abstract class unclassified_Cichlidae : Cichlidae, Iunclassified_Cichlidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cichlidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175426;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cichlidae";
}
