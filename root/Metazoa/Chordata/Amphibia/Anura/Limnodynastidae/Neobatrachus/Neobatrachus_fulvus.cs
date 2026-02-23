namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Neobatrachus;

/// <summary>
/// Species: Neobatrachus fulvus
/// NCBI TaxId: 51247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neobatrachus_fulvus : Neobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neobatrachus fulvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neobatrachus_fulvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51247;
}
