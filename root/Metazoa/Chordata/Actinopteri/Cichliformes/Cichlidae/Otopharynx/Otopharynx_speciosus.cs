namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Otopharynx;

/// <summary>
/// Species: Otopharynx speciosus
/// NCBI TaxId: 163630
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otopharynx_speciosus : Otopharynx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otopharynx speciosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otopharynx_speciosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 163630;
}
