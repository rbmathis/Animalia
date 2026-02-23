namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Brycon;

/// <summary>
/// Species: Brycon amazonicus
/// NCBI TaxId: 387481
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brycon_amazonicus : Brycon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brycon amazonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brycon_amazonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 387481;
}
