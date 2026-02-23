using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Corydoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Corydoras.unclassified_Corydoras;

/// <summary>
/// Abstract class for unclassified Corydoras (no rank).
/// NCBI TaxId: 2626784
/// </summary>
public abstract class unclassified_Corydoras : Corydoras, Iunclassified_Corydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Corydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626784;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Corydoras";
}
