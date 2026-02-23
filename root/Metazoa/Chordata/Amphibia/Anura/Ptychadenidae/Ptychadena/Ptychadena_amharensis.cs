namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena;

/// <summary>
/// Species: Ptychadena amharensis
/// NCBI TaxId: 2806112
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptychadena_amharensis : Ptychadena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptychadena amharensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptychadena_amharensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2806112;
}
