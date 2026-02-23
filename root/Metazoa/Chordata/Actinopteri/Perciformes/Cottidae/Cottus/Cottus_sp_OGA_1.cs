namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottus;

/// <summary>
/// Species: Cottus sp. OGA-1
/// NCBI TaxId: 354138
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cottus_sp_OGA_1 : Cottus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cottus sp. OGA-1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cottus_sp_OGA_1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 354138;
}
