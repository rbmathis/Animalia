namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Loriculus;

/// <summary>
/// Species: Loriculus aurantiifrons
/// NCBI TaxId: 2282772
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loriculus_aurantiifrons : Loriculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loriculus aurantiifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loriculus_aurantiifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2282772;
}
