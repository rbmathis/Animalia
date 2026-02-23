using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Soleichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Soleichthys.unclassified_Soleichthys;

/// <summary>
/// Abstract class for unclassified Soleichthys (no rank).
/// NCBI TaxId: 2639146
/// </summary>
public abstract class unclassified_Soleichthys : Soleichthys, Iunclassified_Soleichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Soleichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639146;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Soleichthys";
}
