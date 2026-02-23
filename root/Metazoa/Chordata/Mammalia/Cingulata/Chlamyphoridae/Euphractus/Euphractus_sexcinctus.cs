namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Euphractus;

/// <summary>
/// Species: Euphractus sexcinctus
/// NCBI TaxId: 143300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euphractus_sexcinctus : Euphractus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euphractus sexcinctus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euphractus_sexcinctus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143300;
}
