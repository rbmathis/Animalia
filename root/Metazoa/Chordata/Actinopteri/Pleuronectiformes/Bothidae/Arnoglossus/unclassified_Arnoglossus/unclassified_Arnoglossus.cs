using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Arnoglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Arnoglossus.unclassified_Arnoglossus;

/// <summary>
/// Abstract class for unclassified Arnoglossus (no rank).
/// NCBI TaxId: 2640409
/// </summary>
public abstract class unclassified_Arnoglossus : Arnoglossus, Iunclassified_Arnoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arnoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640409;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arnoglossus";
}
