using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Chrysoblephus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Chrysoblephus.unclassified_Chrysoblephus;

/// <summary>
/// Abstract class for unclassified Chrysoblephus (no rank).
/// NCBI TaxId: 2644562
/// </summary>
public abstract class unclassified_Chrysoblephus : Chrysoblephus, Iunclassified_Chrysoblephus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chrysoblephus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644562;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chrysoblephus";
}
