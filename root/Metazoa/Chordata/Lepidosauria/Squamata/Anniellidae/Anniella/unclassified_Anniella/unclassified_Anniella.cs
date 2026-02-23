using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anniellidae.Anniella;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anniellidae.Anniella.unclassified_Anniella;

/// <summary>
/// Abstract class for unclassified Anniella (no rank).
/// NCBI TaxId: 2796986
/// </summary>
public abstract class unclassified_Anniella : Anniella, Iunclassified_Anniella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anniella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2796986;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anniella";
}
