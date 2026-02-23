using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Ameiva;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Ameiva.unclassified_Ameiva;

/// <summary>
/// Abstract class for unclassified Ameiva (no rank).
/// NCBI TaxId: 2647154
/// </summary>
public abstract class unclassified_Ameiva : Ameiva, Iunclassified_Ameiva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ameiva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647154;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ameiva";
}
