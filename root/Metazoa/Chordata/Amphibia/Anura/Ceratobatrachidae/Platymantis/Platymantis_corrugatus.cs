namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Platymantis;

/// <summary>
/// Species: Platymantis corrugatus
/// NCBI TaxId: 472302
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platymantis_corrugatus : Platymantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platymantis corrugatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platymantis_corrugatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 472302;
}
