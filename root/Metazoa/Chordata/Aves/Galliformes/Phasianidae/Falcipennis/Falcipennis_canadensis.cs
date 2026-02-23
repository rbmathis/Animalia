namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Falcipennis;

/// <summary>
/// Species: Falcipennis canadensis
/// NCBI TaxId: 109674
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falcipennis_canadensis : Falcipennis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falcipennis canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falcipennis_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109674;
}
