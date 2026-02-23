using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Probreviceps;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Probreviceps.unclassified_Probreviceps;

/// <summary>
/// Abstract class for unclassified Probreviceps (no rank).
/// NCBI TaxId: 2635415
/// </summary>
public abstract class unclassified_Probreviceps : Probreviceps, Iunclassified_Probreviceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Probreviceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635415;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Probreviceps";
}
