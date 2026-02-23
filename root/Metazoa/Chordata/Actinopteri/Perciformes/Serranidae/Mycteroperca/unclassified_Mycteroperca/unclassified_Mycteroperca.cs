using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Mycteroperca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Mycteroperca.unclassified_Mycteroperca;

/// <summary>
/// Abstract class for unclassified Mycteroperca (no rank).
/// NCBI TaxId: 2620558
/// </summary>
public abstract class unclassified_Mycteroperca : Mycteroperca, Iunclassified_Mycteroperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mycteroperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620558;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mycteroperca";
}
