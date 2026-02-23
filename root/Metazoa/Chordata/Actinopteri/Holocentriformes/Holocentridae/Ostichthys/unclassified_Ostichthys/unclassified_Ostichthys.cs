using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Ostichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Ostichthys.unclassified_Ostichthys;

/// <summary>
/// Abstract class for unclassified Ostichthys (no rank).
/// NCBI TaxId: 2954761
/// </summary>
public abstract class unclassified_Ostichthys : Ostichthys, Iunclassified_Ostichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ostichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2954761;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ostichthys";
}
