namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Geophagus;

/// <summary>
/// Species: Geophagus cf. proximus
/// NCBI TaxId: 81360
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geophagus_cf_proximus : Geophagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geophagus cf. proximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geophagus_cf_proximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81360;
}
