namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lontra;

/// <summary>
/// Species: Lontra felina
/// NCBI TaxId: 76718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lontra_felina : Lontra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lontra felina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lontra_felina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 76718;
}
