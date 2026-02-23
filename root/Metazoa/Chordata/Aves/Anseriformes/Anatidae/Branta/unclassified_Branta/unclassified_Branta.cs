using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta.unclassified_Branta;

/// <summary>
/// Abstract class for unclassified Branta (no rank).
/// NCBI TaxId: 2625966
/// </summary>
public abstract class unclassified_Branta : Branta, Iunclassified_Branta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Branta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625966;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Branta";
}
