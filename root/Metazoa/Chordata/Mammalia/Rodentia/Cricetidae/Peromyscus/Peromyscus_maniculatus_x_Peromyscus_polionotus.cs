namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Peromyscus;

/// <summary>
/// Species: Peromyscus maniculatus x Peromyscus polionotus
/// NCBI TaxId: 2907854
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peromyscus_maniculatus_x_Peromyscus_polionotus : Peromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peromyscus maniculatus x Peromyscus polionotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peromyscus_maniculatus_x_Peromyscus_polionotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2907854;
}
