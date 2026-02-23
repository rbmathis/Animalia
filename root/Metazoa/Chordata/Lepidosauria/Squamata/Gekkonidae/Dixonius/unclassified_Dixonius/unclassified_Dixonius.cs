using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Dixonius;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Dixonius.unclassified_Dixonius;

/// <summary>
/// Abstract class for unclassified Dixonius (no rank).
/// NCBI TaxId: 2649928
/// </summary>
public abstract class unclassified_Dixonius : Dixonius, Iunclassified_Dixonius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dixonius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649928;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dixonius";
}
