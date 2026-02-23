namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Aratinga;

/// <summary>
/// Species: Aratinga auricapillus
/// NCBI TaxId: 867384
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aratinga_auricapillus : Aratinga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aratinga auricapillus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aratinga_auricapillus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867384;
}
