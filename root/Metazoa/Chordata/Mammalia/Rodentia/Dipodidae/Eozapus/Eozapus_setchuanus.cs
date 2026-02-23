namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Eozapus;

/// <summary>
/// Species: Eozapus setchuanus
/// NCBI TaxId: 101673
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eozapus_setchuanus : Eozapus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eozapus setchuanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eozapus_setchuanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 101673;
}
