namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Dendrobates;

/// <summary>
/// Species: Dendrobates leucomelas
/// NCBI TaxId: 85590
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendrobates_leucomelas : Dendrobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendrobates leucomelas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendrobates_leucomelas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85590;
}
