namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Anura;

/// <summary>
/// Species: Anura sp. BOLD:AAE7181
/// NCBI TaxId: 815480
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anura_sp_BOLDAAE7181 : unclassified_Anura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anura sp. BOLD:AAE7181";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anura_sp_BOLDAAE7181";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 815480;
}
