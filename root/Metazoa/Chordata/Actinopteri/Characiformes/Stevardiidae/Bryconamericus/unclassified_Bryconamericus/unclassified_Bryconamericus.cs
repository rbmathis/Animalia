using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Bryconamericus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Bryconamericus.unclassified_Bryconamericus;

/// <summary>
/// Abstract class for unclassified Bryconamericus (no rank).
/// NCBI TaxId: 2602620
/// </summary>
public abstract class unclassified_Bryconamericus : Bryconamericus, Iunclassified_Bryconamericus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bryconamericus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602620;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bryconamericus";
}
