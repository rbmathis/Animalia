namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae.Giraffa;

/// <summary>
/// Species: Giraffa sp.
/// NCBI TaxId: 3039165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Giraffa_sp : Giraffa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Giraffa sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Giraffa_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3039165;
}
