namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Heteromys;

/// <summary>
/// Species: Heteromys sp. DSR-2010
/// NCBI TaxId: 885259
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heteromys_sp_DSR_2010 : Heteromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heteromys sp. DSR-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heteromys_sp_DSR_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 885259;
}
