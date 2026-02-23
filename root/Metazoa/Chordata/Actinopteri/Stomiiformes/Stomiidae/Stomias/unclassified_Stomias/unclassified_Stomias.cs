using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Stomias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Stomias.unclassified_Stomias;

/// <summary>
/// Abstract class for unclassified Stomias (no rank).
/// NCBI TaxId: 2622146
/// </summary>
public abstract class unclassified_Stomias : Stomias, Iunclassified_Stomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622146;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stomias";
}
