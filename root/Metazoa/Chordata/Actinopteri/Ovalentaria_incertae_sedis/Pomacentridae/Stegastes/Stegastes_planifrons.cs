namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

/// <summary>
/// Species: Stegastes planifrons
/// NCBI TaxId: 159713
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stegastes_planifrons : Stegastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stegastes planifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stegastes_planifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 159713;
}
