namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Pellorneum;

/// <summary>
/// Species: Pellorneum cinereiceps
/// NCBI TaxId: 3150300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pellorneum_cinereiceps : Pellorneum
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pellorneum cinereiceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pellorneum_cinereiceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150300;
}
