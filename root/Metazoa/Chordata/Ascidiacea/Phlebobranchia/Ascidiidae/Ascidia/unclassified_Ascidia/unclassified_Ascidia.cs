using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Ascidia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Ascidia.unclassified_Ascidia;

/// <summary>
/// Abstract class for unclassified Ascidia (no rank).
/// NCBI TaxId: 2626309
/// </summary>
public abstract class unclassified_Ascidia : Ascidia, Iunclassified_Ascidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ascidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626309;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ascidia";
}
