using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Lophodolos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Lophodolos.unclassified_Lophodolos;

/// <summary>
/// Abstract class for unclassified Lophodolos (no rank).
/// NCBI TaxId: 2623708
/// </summary>
public abstract class unclassified_Lophodolos : Lophodolos, Iunclassified_Lophodolos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lophodolos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623708;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lophodolos";
}
