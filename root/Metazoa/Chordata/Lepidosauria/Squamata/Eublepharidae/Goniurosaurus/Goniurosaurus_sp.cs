namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Goniurosaurus;

/// <summary>
/// Species: Goniurosaurus sp.
/// NCBI TaxId: 99191
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Goniurosaurus_sp : Goniurosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Goniurosaurus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Goniurosaurus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99191;
}
