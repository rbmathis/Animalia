namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Osteomugil;

/// <summary>
/// Species: Osteomugil sp.
/// NCBI TaxId: 3112287
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteomugil_sp : Osteomugil
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteomugil sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteomugil_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3112287;
}
