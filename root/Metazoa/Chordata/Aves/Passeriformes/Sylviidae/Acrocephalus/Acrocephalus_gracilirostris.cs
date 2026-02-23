namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Acrocephalus;

/// <summary>
/// Species: Acrocephalus gracilirostris
/// NCBI TaxId: 68482
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acrocephalus_gracilirostris : Acrocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acrocephalus gracilirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acrocephalus_gracilirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68482;
}
