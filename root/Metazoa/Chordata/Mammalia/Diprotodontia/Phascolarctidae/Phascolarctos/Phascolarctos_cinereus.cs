namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phascolarctidae.Phascolarctos;

/// <summary>
/// Species: Phascolarctos cinereus
/// NCBI TaxId: 38626
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phascolarctos_cinereus : Phascolarctos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phascolarctos cinereus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phascolarctos_cinereus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38626;
}
