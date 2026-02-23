namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dryocopus;

/// <summary>
/// Species: Dryocopus pileatus
/// NCBI TaxId: 51359
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dryocopus_pileatus : Dryocopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dryocopus pileatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dryocopus_pileatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51359;
}
