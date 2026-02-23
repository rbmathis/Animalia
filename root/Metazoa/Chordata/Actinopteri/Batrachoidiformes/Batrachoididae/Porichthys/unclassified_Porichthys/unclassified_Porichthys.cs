using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Porichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Porichthys.unclassified_Porichthys;

/// <summary>
/// Abstract class for unclassified Porichthys (no rank).
/// NCBI TaxId: 2626990
/// </summary>
public abstract class unclassified_Porichthys : Porichthys, Iunclassified_Porichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Porichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626990;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Porichthys";
}
