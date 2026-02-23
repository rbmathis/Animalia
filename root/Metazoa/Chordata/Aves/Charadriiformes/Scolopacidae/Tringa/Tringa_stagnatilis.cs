namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

/// <summary>
/// Species: Tringa stagnatilis
/// NCBI TaxId: 322584
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tringa_stagnatilis : Tringa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tringa stagnatilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tringa_stagnatilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 322584;
}
