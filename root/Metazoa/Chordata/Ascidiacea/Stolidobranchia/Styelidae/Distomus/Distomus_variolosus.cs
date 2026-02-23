namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Distomus;

/// <summary>
/// Species: Distomus variolosus
/// NCBI TaxId: 581068
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Distomus_variolosus : Distomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Distomus variolosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Distomus_variolosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 581068;
}
