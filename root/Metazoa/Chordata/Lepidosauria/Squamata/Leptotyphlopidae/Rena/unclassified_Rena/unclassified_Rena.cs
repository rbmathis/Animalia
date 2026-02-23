using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Rena;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Rena.unclassified_Rena;

/// <summary>
/// Abstract class for unclassified Rena (no rank).
/// NCBI TaxId: 2617837
/// </summary>
public abstract class unclassified_Rena : Rena, Iunclassified_Rena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617837;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rena";
}
