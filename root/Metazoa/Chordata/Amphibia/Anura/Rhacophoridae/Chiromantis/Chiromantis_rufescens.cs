namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Chiromantis;

/// <summary>
/// Species: Chiromantis rufescens
/// NCBI TaxId: 143502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiromantis_rufescens : Chiromantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiromantis rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiromantis_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143502;
}
