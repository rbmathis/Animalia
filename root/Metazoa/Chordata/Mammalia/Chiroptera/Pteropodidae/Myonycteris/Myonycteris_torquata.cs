namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Myonycteris;

/// <summary>
/// Species: Myonycteris torquata
/// NCBI TaxId: 77243
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myonycteris_torquata : Myonycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myonycteris torquata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myonycteris_torquata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 77243;
}
