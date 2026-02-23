using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Herichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Herichthys.unclassified_Herichthys;

/// <summary>
/// Abstract class for unclassified Herichthys (no rank).
/// NCBI TaxId: 2646057
/// </summary>
public abstract class unclassified_Herichthys : Herichthys, Iunclassified_Herichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Herichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646057;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Herichthys";
}
