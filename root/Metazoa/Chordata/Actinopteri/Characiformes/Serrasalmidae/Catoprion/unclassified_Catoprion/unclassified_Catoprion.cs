using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Catoprion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Catoprion.unclassified_Catoprion;

/// <summary>
/// Abstract class for unclassified Catoprion (no rank).
/// NCBI TaxId: 2705583
/// </summary>
public abstract class unclassified_Catoprion : Catoprion, Iunclassified_Catoprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Catoprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2705583;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Catoprion";
}
