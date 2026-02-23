namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Platymantis;

/// <summary>
/// Species: Platymantis levigatus
/// NCBI TaxId: 1598021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platymantis_levigatus : Platymantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platymantis levigatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platymantis_levigatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1598021;
}
