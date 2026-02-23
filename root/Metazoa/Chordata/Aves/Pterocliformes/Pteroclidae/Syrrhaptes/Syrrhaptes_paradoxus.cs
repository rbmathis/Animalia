namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pterocliformes.Pteroclidae.Syrrhaptes;

/// <summary>
/// Species: Syrrhaptes paradoxus
/// NCBI TaxId: 302527
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Syrrhaptes_paradoxus : Syrrhaptes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Syrrhaptes paradoxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Syrrhaptes_paradoxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 302527;
}
