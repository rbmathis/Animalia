using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Phyllichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Phyllichthys.unclassified_Phyllichthys;

/// <summary>
/// Abstract class for unclassified Phyllichthys (no rank).
/// NCBI TaxId: 2755203
/// </summary>
public abstract class unclassified_Phyllichthys : Phyllichthys, Iunclassified_Phyllichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2755203;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllichthys";
}
