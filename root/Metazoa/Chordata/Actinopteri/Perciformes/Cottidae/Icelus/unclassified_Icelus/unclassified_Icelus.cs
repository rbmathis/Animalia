using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Icelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Icelus.unclassified_Icelus;

/// <summary>
/// Abstract class for unclassified Icelus (no rank).
/// NCBI TaxId: 2647520
/// </summary>
public abstract class unclassified_Icelus : Icelus, Iunclassified_Icelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Icelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647520;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Icelus";
}
