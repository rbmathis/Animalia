namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Galerella;

/// <summary>
/// Species: Galerella nigrata x sanguinea
/// NCBI TaxId: 1230393
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galerella_nigrata_x_sanguinea : Galerella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galerella nigrata x sanguinea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galerella_nigrata_x_sanguinea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1230393;
}
