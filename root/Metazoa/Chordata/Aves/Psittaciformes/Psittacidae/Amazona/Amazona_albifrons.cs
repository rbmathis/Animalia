namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona albifrons
/// NCBI TaxId: 241569
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_albifrons : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona albifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_albifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241569;
}
