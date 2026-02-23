namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Zimmerius;

/// <summary>
/// Species: Zimmerius viridiflavus
/// NCBI TaxId: 502662
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zimmerius_viridiflavus : Zimmerius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zimmerius viridiflavus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zimmerius_viridiflavus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 502662;
}
