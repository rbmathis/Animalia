namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Centrochelys;

/// <summary>
/// Species: Centrochelys sulcata
/// NCBI TaxId: 1540822
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Centrochelys_sulcata : Centrochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Centrochelys sulcata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Centrochelys_sulcata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1540822;
}
