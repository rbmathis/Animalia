using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Stenotomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Stenotomus.unclassified_Stenotomus;

/// <summary>
/// Abstract class for unclassified Stenotomus (no rank).
/// NCBI TaxId: 2743066
/// </summary>
public abstract class unclassified_Stenotomus : Stenotomus, Iunclassified_Stenotomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stenotomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2743066;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stenotomus";
}
