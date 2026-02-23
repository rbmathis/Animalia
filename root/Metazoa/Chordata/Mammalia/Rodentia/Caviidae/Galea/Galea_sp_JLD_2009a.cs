namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Galea;

/// <summary>
/// Species: Galea sp. JLD-2009a
/// NCBI TaxId: 686679
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galea_sp_JLD_2009a : Galea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galea sp. JLD-2009a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galea_sp_JLD_2009a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 686679;
}
