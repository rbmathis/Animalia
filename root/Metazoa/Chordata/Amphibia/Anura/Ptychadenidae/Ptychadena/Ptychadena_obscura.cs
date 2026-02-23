namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena;

/// <summary>
/// Species: Ptychadena obscura
/// NCBI TaxId: 2546001
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptychadena_obscura : Ptychadena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptychadena obscura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptychadena_obscura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2546001;
}
