using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis;

/// <summary>
/// Abstract class for Labeoninae incertae sedis (no rank).
/// NCBI TaxId: 2743700
/// </summary>
public abstract class Labeoninae_incertae_sedis : Cyprinidae, ILabeoninae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labeoninae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2743700;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Labeoninae_incertae_sedis";
}
