using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Otopharynx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Otopharynx.unclassified_Otopharynx;

/// <summary>
/// Abstract class for unclassified Otopharynx (no rank).
/// NCBI TaxId: 2633520
/// </summary>
public abstract class unclassified_Otopharynx : Otopharynx, Iunclassified_Otopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Otopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633520;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Otopharynx";
}
