namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Mungos;

/// <summary>
/// Species: Mungos mungo
/// NCBI TaxId: 210652
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mungos_mungo : Mungos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mungos mungo";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mungos_mungo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 210652;
}
