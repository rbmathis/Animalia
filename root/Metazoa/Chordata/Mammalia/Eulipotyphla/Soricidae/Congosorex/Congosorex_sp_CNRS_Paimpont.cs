namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Congosorex;

/// <summary>
/// Species: Congosorex sp. CNRS_Paimpont
/// NCBI TaxId: 150111
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Congosorex_sp_CNRS_Paimpont : Congosorex
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Congosorex sp. CNRS_Paimpont";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Congosorex_sp_CNRS_Paimpont";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150111;
}
