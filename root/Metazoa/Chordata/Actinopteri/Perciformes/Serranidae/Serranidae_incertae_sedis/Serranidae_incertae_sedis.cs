using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Serranidae_incertae_sedis;

/// <summary>
/// Abstract class for Serranidae incertae sedis (no rank).
/// NCBI TaxId: 1379458
/// </summary>
public abstract class Serranidae_incertae_sedis : Serranidae, ISerranidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serranidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1379458;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Serranidae_incertae_sedis";
}
