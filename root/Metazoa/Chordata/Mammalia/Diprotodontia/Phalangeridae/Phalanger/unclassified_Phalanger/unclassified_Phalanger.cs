using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Phalanger;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Phalanger.unclassified_Phalanger;

/// <summary>
/// Abstract class for unclassified Phalanger (no rank).
/// NCBI TaxId: 2795613
/// </summary>
public abstract class unclassified_Phalanger : Phalanger, Iunclassified_Phalanger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phalanger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2795613;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phalanger";
}
