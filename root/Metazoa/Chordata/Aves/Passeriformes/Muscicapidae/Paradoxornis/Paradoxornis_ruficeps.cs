namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Paradoxornis;

/// <summary>
/// Species: Paradoxornis ruficeps
/// NCBI TaxId: 1071657
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paradoxornis_ruficeps : Paradoxornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paradoxornis ruficeps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paradoxornis_ruficeps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1071657;
}
