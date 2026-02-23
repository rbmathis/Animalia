using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Saccopharyngidae.Saccopharynx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Saccopharyngidae.Saccopharynx.unclassified_Saccopharynx;

/// <summary>
/// Abstract class for unclassified Saccopharynx (no rank).
/// NCBI TaxId: 2630149
/// </summary>
public abstract class unclassified_Saccopharynx : Saccopharynx, Iunclassified_Saccopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saccopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630149;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saccopharynx";
}
