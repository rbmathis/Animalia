namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dryocopus;

/// <summary>
/// Species: Dryocopus schulzii
/// NCBI TaxId: 3149811
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dryocopus_schulzii : Dryocopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dryocopus schulzii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dryocopus_schulzii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3149811;
}
