using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor.unclassified_Craugastor;

/// <summary>
/// Abstract class for unclassified Craugastor (no rank).
/// NCBI TaxId: 2633331
/// </summary>
public abstract class unclassified_Craugastor : Craugastor, Iunclassified_Craugastor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Craugastor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633331;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Craugastor";
}
