namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Homo;

/// <summary>
/// Species: Homo sp.
/// NCBI TaxId: 2813599
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homo_sp : Homo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homo sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homo_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2813599;
}
