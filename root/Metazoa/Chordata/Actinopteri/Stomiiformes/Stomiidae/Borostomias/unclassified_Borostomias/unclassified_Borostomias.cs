using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Borostomias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Borostomias.unclassified_Borostomias;

/// <summary>
/// Abstract class for unclassified Borostomias (no rank).
/// NCBI TaxId: 2618067
/// </summary>
public abstract class unclassified_Borostomias : Borostomias, Iunclassified_Borostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Borostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618067;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Borostomias";
}
