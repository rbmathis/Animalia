using AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis;

/// <summary>
/// Abstract class for Carangaria incertae sedis (no rank).
/// NCBI TaxId: 1489905
/// </summary>
public abstract class Carangaria_incertae_sedis : Actinopteri, ICarangaria_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carangaria incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489905;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Carangaria_incertae_sedis";
}
