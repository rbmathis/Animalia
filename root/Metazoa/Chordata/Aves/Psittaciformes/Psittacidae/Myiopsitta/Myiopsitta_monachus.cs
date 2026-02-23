namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Myiopsitta;

/// <summary>
/// Species: Myiopsitta monachus
/// NCBI TaxId: 176066
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiopsitta_monachus : Myiopsitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiopsitta monachus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiopsitta_monachus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176066;
}
