namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Neobatrachus;

/// <summary>
/// Species: Neobatrachus pictus
/// NCBI TaxId: 51249
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neobatrachus_pictus : Neobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neobatrachus pictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neobatrachus_pictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51249;
}
