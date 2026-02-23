namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena;

/// <summary>
/// Species: Ptychadena nilotica
/// NCBI TaxId: 1380080
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptychadena_nilotica : Ptychadena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptychadena nilotica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptychadena_nilotica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1380080;
}
