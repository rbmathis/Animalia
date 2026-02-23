namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Panthera;

/// <summary>
/// Species: Panthera uncia
/// NCBI TaxId: 29064
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Panthera_uncia : Panthera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Panthera uncia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Panthera_uncia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29064;
}
