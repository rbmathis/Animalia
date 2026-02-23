namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Oxyura;

/// <summary>
/// Species: Oxyura ferruginea
/// NCBI TaxId: 555300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oxyura_ferruginea : Oxyura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oxyura ferruginea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oxyura_ferruginea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555300;
}
