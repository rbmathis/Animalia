using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Neobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Neobatrachus.unclassified_Neobatrachus;

/// <summary>
/// Abstract class for unclassified Neobatrachus (no rank).
/// NCBI TaxId: 3243160
/// </summary>
public abstract class unclassified_Neobatrachus : Neobatrachus, Iunclassified_Neobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3243160;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neobatrachus";
}
