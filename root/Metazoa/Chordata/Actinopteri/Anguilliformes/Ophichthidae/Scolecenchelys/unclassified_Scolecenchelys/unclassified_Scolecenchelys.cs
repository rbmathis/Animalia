using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Scolecenchelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Scolecenchelys.unclassified_Scolecenchelys;

/// <summary>
/// Abstract class for unclassified Scolecenchelys (no rank).
/// NCBI TaxId: 2623219
/// </summary>
public abstract class unclassified_Scolecenchelys : Scolecenchelys, Iunclassified_Scolecenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scolecenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623219;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scolecenchelys";
}
