namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Platymantis;

/// <summary>
/// Species: Platymantis sp. MIS-2009
/// NCBI TaxId: 645718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platymantis_sp_MIS_2009 : Platymantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platymantis sp. MIS-2009";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platymantis_sp_MIS_2009";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 645718;
}
