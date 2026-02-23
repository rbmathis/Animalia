using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis;

/// <summary>
/// Abstract class for Perciformes incertae sedis (no rank).
/// NCBI TaxId: 1489941
/// </summary>
public abstract class Perciformes_incertae_sedis : Perciformes, IPerciformes_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perciformes incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489941;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Perciformes_incertae_sedis";
}
