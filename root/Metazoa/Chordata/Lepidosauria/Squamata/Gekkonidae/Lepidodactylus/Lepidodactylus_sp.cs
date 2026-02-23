namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lepidodactylus;

/// <summary>
/// Species: Lepidodactylus sp.
/// NCBI TaxId: 47726
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidodactylus_sp : Lepidodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidodactylus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidodactylus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 47726;
}
