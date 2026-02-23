using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Eurypharyngidae.Eurypharynx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Eurypharyngidae.Eurypharynx.unclassified_Eurypharynx;

/// <summary>
/// Abstract class for unclassified Eurypharynx (no rank).
/// NCBI TaxId: 2634711
/// </summary>
public abstract class unclassified_Eurypharynx : Eurypharynx, Iunclassified_Eurypharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eurypharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634711;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eurypharynx";
}
