using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Anodonthyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Anodonthyla.unclassified_Anodonthyla;

/// <summary>
/// Abstract class for unclassified Anodonthyla (no rank).
/// NCBI TaxId: 2626629
/// </summary>
public abstract class unclassified_Anodonthyla : Anodonthyla, Iunclassified_Anodonthyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anodonthyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626629;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anodonthyla";
}
