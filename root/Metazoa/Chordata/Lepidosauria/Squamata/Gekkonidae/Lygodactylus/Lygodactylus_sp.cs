namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lygodactylus;

/// <summary>
/// Species: Lygodactylus sp.
/// NCBI TaxId: 2782519
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lygodactylus_sp : Lygodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lygodactylus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lygodactylus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2782519;
}
