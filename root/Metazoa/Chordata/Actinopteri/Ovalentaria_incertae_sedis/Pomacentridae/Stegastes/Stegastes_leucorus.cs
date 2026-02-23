namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Stegastes;

/// <summary>
/// Species: Stegastes leucorus
/// NCBI TaxId: 1350521
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stegastes_leucorus : Stegastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stegastes leucorus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stegastes_leucorus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1350521;
}
