using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polycarpa;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Polycarpa.unclassified_Polycarpa;

/// <summary>
/// Abstract class for unclassified Polycarpa (no rank).
/// NCBI TaxId: 2631405
/// </summary>
public abstract class unclassified_Polycarpa : Polycarpa, Iunclassified_Polycarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polycarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631405;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polycarpa";
}
