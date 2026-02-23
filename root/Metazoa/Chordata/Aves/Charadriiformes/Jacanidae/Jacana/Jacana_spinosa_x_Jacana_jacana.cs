namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Jacanidae.Jacana;

/// <summary>
/// Species: Jacana spinosa x Jacana jacana
/// NCBI TaxId: 1457350
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Jacana_spinosa_x_Jacana_jacana : Jacana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Jacana spinosa x Jacana jacana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Jacana_spinosa_x_Jacana_jacana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1457350;
}
