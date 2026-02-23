using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Philothamnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Philothamnus.unclassified_Philothamnus;

/// <summary>
/// Abstract class for unclassified Philothamnus (no rank).
/// NCBI TaxId: 2643923
/// </summary>
public abstract class unclassified_Philothamnus : Philothamnus, Iunclassified_Philothamnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Philothamnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643923;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Philothamnus";
}
