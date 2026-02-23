using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Leptoclinides;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Leptoclinides.unclassified_Leptoclinides;

/// <summary>
/// Abstract class for unclassified Leptoclinides (no rank).
/// NCBI TaxId: 2829868
/// </summary>
public abstract class unclassified_Leptoclinides : Leptoclinides, Iunclassified_Leptoclinides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptoclinides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2829868;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptoclinides";
}
