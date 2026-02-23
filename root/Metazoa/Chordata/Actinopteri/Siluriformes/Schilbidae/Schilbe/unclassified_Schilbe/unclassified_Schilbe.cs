using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Schilbe;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Schilbe.unclassified_Schilbe;

/// <summary>
/// Abstract class for unclassified Schilbe (no rank).
/// NCBI TaxId: 2637128
/// </summary>
public abstract class unclassified_Schilbe : Schilbe, Iunclassified_Schilbe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Schilbe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637128;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Schilbe";
}
