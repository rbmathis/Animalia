namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Hirundinea;

/// <summary>
/// Species: Hirundinea ferruginea
/// NCBI TaxId: 495202
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hirundinea_ferruginea : Hirundinea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hirundinea ferruginea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hirundinea_ferruginea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 495202;
}
