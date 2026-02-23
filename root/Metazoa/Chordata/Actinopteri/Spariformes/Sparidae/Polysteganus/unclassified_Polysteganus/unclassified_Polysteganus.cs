using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Polysteganus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Polysteganus.unclassified_Polysteganus;

/// <summary>
/// Abstract class for unclassified Polysteganus (no rank).
/// NCBI TaxId: 2626290
/// </summary>
public abstract class unclassified_Polysteganus : Polysteganus, Iunclassified_Polysteganus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polysteganus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626290;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polysteganus";
}
