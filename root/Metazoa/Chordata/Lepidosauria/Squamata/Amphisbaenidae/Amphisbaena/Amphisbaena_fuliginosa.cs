namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Amphisbaena;

/// <summary>
/// Species: Amphisbaena fuliginosa
/// NCBI TaxId: 643087
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphisbaena_fuliginosa : Amphisbaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphisbaena fuliginosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphisbaena_fuliginosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643087;
}
