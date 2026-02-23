namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

/// <summary>
/// Species: Pachycephala pectoralis
/// NCBI TaxId: 46904
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachycephala_pectoralis : Pachycephala
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachycephala pectoralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachycephala_pectoralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46904;
}
