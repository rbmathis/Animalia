namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Bucephala;

/// <summary>
/// Species: Bucephala islandica x Bucephala albeola
/// NCBI TaxId: 2823289
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bucephala_islandica_x_Bucephala_albeola : Bucephala
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bucephala islandica x Bucephala albeola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bucephala_islandica_x_Bucephala_albeola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2823289;
}
