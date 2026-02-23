namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Pomatostomus;

/// <summary>
/// Species: Pomatostomus temporalis
/// NCBI TaxId: 9178
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pomatostomus_temporalis : Pomatostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pomatostomus temporalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pomatostomus_temporalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9178;
}
