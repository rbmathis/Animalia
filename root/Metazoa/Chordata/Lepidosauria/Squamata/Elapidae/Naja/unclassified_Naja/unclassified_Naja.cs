using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja.unclassified_Naja;

/// <summary>
/// Abstract class for unclassified Naja (no rank).
/// NCBI TaxId: 2631638
/// </summary>
public abstract class unclassified_Naja : Naja, Iunclassified_Naja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Naja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631638;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Naja";
}
