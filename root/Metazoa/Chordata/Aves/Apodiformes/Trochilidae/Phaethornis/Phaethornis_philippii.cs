namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Phaethornis;

/// <summary>
/// Species: Phaethornis philippii
/// NCBI TaxId: 472906
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phaethornis_philippii : Phaethornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phaethornis philippii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phaethornis_philippii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 472906;
}
