namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo sp. 'Botsalano'
/// NCBI TaxId: 125254
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_sp_Botsalano : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo sp. 'Botsalano'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_sp_Botsalano";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 125254;
}
