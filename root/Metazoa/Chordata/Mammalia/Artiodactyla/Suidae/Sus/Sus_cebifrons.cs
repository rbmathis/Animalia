namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus;

/// <summary>
/// Species: Sus cebifrons
/// NCBI TaxId: 315377
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sus_cebifrons : Sus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sus cebifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sus_cebifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 315377;
}
