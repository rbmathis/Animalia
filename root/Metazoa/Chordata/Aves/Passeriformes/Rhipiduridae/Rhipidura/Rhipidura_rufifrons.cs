namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Rhipidura;

/// <summary>
/// Species: Rhipidura rufifrons
/// NCBI TaxId: 135976
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhipidura_rufifrons : Rhipidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhipidura rufifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhipidura_rufifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 135976;
}
