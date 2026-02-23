using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Dagetichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Dagetichthys.unclassified_Dagetichthys;

/// <summary>
/// Abstract class for unclassified Dagetichthys (no rank).
/// NCBI TaxId: 2650290
/// </summary>
public abstract class unclassified_Dagetichthys : Dagetichthys, Iunclassified_Dagetichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dagetichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650290;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dagetichthys";
}
