namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys;

/// <summary>
/// Species: Chrysemys sp.
/// NCBI TaxId: 2291712
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chrysemys_sp : Chrysemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chrysemys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chrysemys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2291712;
}
