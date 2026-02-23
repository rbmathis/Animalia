using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Pseudostegophilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Pseudostegophilus.unclassified_Pseudostegophilus;

/// <summary>
/// Abstract class for unclassified Pseudostegophilus (no rank).
/// NCBI TaxId: 2631670
/// </summary>
public abstract class unclassified_Pseudostegophilus : Pseudostegophilus, Iunclassified_Pseudostegophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudostegophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631670;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudostegophilus";
}
