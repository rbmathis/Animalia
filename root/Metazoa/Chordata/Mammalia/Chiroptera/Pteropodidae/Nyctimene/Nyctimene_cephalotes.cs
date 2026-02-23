namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Nyctimene;

/// <summary>
/// Species: Nyctimene cephalotes
/// NCBI TaxId: 170209
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctimene_cephalotes : Nyctimene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctimene cephalotes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctimene_cephalotes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 170209;
}
