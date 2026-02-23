namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Hyloxalus;

/// <summary>
/// Species: Hyloxalus insulatus
/// NCBI TaxId: 384865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyloxalus_insulatus : Hyloxalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyloxalus insulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyloxalus_insulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 384865;
}
