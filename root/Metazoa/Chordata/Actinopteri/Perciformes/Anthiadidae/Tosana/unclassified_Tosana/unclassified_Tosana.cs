using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Tosana;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Tosana.unclassified_Tosana;

/// <summary>
/// Abstract class for unclassified Tosana (no rank).
/// NCBI TaxId: 3414477
/// </summary>
public abstract class unclassified_Tosana : Tosana, Iunclassified_Tosana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tosana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3414477;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tosana";
}
