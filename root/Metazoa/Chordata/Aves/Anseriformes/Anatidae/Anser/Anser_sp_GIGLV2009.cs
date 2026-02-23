namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

/// <summary>
/// Species: Anser sp. GIGLV2009
/// NCBI TaxId: 713105
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anser_sp_GIGLV2009 : Anser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anser sp. GIGLV2009";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anser_sp_GIGLV2009";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 713105;
}
