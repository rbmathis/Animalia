namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

/// <summary>
/// Species: Pachycephala graeffii
/// NCBI TaxId: 1448011
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachycephala_graeffii : Pachycephala
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachycephala graeffii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachycephala_graeffii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1448011;
}
