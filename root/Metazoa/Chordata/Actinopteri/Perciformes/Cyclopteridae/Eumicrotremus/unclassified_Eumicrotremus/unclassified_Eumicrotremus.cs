using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Eumicrotremus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Eumicrotremus.unclassified_Eumicrotremus;

/// <summary>
/// Abstract class for unclassified Eumicrotremus (no rank).
/// NCBI TaxId: 2643155
/// </summary>
public abstract class unclassified_Eumicrotremus : Eumicrotremus, Iunclassified_Eumicrotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eumicrotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643155;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eumicrotremus";
}
