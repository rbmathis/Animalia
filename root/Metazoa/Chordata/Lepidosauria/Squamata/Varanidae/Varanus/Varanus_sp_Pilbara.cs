namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus sp. Pilbara
/// NCBI TaxId: 386769
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_sp_Pilbara : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus sp. Pilbara";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_sp_Pilbara";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 386769;
}
