using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Tentoriceps;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Tentoriceps.unclassified_Tentoriceps;

/// <summary>
/// Abstract class for unclassified Tentoriceps (no rank).
/// NCBI TaxId: 2645796
/// </summary>
public abstract class unclassified_Tentoriceps : Tentoriceps, Iunclassified_Tentoriceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tentoriceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645796;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tentoriceps";
}
