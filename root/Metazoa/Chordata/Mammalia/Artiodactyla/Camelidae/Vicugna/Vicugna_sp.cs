namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Vicugna;

/// <summary>
/// Species: Vicugna sp.
/// NCBI TaxId: 3396594
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vicugna_sp : Vicugna
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vicugna sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vicugna_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3396594;
}
