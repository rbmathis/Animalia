namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Martes;

/// <summary>
/// Species: Martes zibellina
/// NCBI TaxId: 36722
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Martes_zibellina : Martes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Martes zibellina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Martes_zibellina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36722;
}
