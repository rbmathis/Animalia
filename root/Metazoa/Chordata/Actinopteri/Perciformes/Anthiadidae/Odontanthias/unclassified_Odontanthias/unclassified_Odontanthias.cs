using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Odontanthias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Odontanthias.unclassified_Odontanthias;

/// <summary>
/// Abstract class for unclassified Odontanthias (no rank).
/// NCBI TaxId: 2619382
/// </summary>
public abstract class unclassified_Odontanthias : Odontanthias, Iunclassified_Odontanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619382;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontanthias";
}
