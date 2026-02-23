namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacula;

/// <summary>
/// Species: Psittacula columboides
/// NCBI TaxId: 232642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacula_columboides : Psittacula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacula columboides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacula_columboides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 232642;
}
