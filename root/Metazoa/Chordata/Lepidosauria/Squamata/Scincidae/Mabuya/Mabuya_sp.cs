namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Mabuya;

/// <summary>
/// Species: Mabuya sp.
/// NCBI TaxId: 155311
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mabuya_sp : Mabuya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mabuya sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mabuya_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 155311;
}
