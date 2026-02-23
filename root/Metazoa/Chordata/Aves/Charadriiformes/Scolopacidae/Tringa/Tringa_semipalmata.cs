namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

/// <summary>
/// Species: Tringa semipalmata
/// NCBI TaxId: 507600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tringa_semipalmata : Tringa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tringa semipalmata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tringa_semipalmata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 507600;
}
