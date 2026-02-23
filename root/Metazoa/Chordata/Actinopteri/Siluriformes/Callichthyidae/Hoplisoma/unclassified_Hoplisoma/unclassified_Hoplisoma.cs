using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Hoplisoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Hoplisoma.unclassified_Hoplisoma;

/// <summary>
/// Abstract class for unclassified Hoplisoma (no rank).
/// NCBI TaxId: 3415586
/// </summary>
public abstract class unclassified_Hoplisoma : Hoplisoma, Iunclassified_Hoplisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3415586;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplisoma";
}
