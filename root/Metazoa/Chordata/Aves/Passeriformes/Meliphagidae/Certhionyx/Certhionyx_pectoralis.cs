namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Certhionyx;

/// <summary>
/// Species: Certhionyx pectoralis
/// NCBI TaxId: 266343
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Certhionyx_pectoralis : Certhionyx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Certhionyx pectoralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Certhionyx_pectoralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 266343;
}
