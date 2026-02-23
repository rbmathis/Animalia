namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllodytes;

/// <summary>
/// Species: Phyllodytes luteolus
/// NCBI TaxId: 318378
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodytes_luteolus : Phyllodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodytes luteolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodytes_luteolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318378;
}
