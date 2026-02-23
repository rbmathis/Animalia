namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys;

/// <summary>
/// Species: Aldabrachelys grandidieri
/// NCBI TaxId: 180172
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aldabrachelys_grandidieri : Aldabrachelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aldabrachelys grandidieri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aldabrachelys_grandidieri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 180172;
}
