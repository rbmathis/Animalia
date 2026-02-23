using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Isbrueckerichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Isbrueckerichthys.unclassified_Isbrueckerichthys;

/// <summary>
/// Abstract class for unclassified Isbrueckerichthys (no rank).
/// NCBI TaxId: 2646971
/// </summary>
public abstract class unclassified_Isbrueckerichthys : Isbrueckerichthys, Iunclassified_Isbrueckerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Isbrueckerichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646971;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Isbrueckerichthys";
}
