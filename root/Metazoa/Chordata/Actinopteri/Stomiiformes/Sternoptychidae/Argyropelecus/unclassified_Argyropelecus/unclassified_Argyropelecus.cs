using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Argyropelecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Argyropelecus.unclassified_Argyropelecus;

/// <summary>
/// Abstract class for unclassified Argyropelecus (no rank).
/// NCBI TaxId: 2630102
/// </summary>
public abstract class unclassified_Argyropelecus : Argyropelecus, Iunclassified_Argyropelecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Argyropelecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630102;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Argyropelecus";
}
