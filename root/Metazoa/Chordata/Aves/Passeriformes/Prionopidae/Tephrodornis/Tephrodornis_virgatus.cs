namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae.Tephrodornis;

/// <summary>
/// Species: Tephrodornis virgatus
/// NCBI TaxId: 316102
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tephrodornis_virgatus : Tephrodornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tephrodornis virgatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tephrodornis_virgatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 316102;
}
