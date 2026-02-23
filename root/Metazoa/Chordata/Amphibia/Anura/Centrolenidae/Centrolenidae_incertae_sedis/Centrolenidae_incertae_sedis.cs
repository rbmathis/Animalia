using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Centrolenidae_incertae_sedis;

/// <summary>
/// Abstract class for Centrolenidae incertae sedis (no rank).
/// NCBI TaxId: 715365
/// </summary>
public abstract class Centrolenidae_incertae_sedis : Centrolenidae, ICentrolenidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrolenidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715365;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Centrolenidae_incertae_sedis";
}
