using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Cnemidocarpa;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Cnemidocarpa.unclassified_Cnemidocarpa;

/// <summary>
/// Abstract class for unclassified Cnemidocarpa (no rank).
/// NCBI TaxId: 2628095
/// </summary>
public abstract class unclassified_Cnemidocarpa : Cnemidocarpa, Iunclassified_Cnemidocarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cnemidocarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cnemidocarpa";
}
