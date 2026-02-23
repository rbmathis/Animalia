namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinopomatidae.Rhinopoma;

/// <summary>
/// Species: Rhinopoma microphyllum
/// NCBI TaxId: 173903
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinopoma_microphyllum : Rhinopoma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinopoma microphyllum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinopoma_microphyllum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 173903;
}
