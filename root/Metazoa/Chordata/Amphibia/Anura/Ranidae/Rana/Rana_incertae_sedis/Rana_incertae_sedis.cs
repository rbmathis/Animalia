using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana.Rana_incertae_sedis;

/// <summary>
/// Abstract class for Rana incertae sedis (no rank).
/// NCBI TaxId: 2932368
/// </summary>
public abstract class Rana_incertae_sedis : Rana, IRana_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rana incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2932368;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Rana_incertae_sedis";
}
