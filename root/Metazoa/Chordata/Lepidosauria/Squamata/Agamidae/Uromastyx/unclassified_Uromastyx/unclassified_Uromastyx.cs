using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Uromastyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Uromastyx.unclassified_Uromastyx;

/// <summary>
/// Abstract class for unclassified Uromastyx (no rank).
/// NCBI TaxId: 2644158
/// </summary>
public abstract class unclassified_Uromastyx : Uromastyx, Iunclassified_Uromastyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uromastyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644158;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uromastyx";
}
