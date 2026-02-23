namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Galerella;

/// <summary>
/// Species: Galerella sanguinea
/// NCBI TaxId: 210644
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galerella_sanguinea : Galerella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galerella sanguinea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galerella_sanguinea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 210644;
}
