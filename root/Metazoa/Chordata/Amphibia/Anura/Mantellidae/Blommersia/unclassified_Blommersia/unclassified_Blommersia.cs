using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Blommersia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Blommersia.unclassified_Blommersia;

/// <summary>
/// Abstract class for unclassified Blommersia (no rank).
/// NCBI TaxId: 2643453
/// </summary>
public abstract class unclassified_Blommersia : Blommersia, Iunclassified_Blommersia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Blommersia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643453;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Blommersia";
}
