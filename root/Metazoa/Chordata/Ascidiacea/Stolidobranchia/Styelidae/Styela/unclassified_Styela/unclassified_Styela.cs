using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Styela;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Styela.unclassified_Styela;

/// <summary>
/// Abstract class for unclassified Styela (no rank).
/// NCBI TaxId: 2625508
/// </summary>
public abstract class unclassified_Styela : Styela, Iunclassified_Styela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Styela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625508;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Styela";
}
