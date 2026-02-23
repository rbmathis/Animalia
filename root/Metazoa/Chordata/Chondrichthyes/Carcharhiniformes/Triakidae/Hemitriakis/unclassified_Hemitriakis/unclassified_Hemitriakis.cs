using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Hemitriakis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Hemitriakis.unclassified_Hemitriakis;

/// <summary>
/// Abstract class for unclassified Hemitriakis (no rank).
/// NCBI TaxId: 2647125
/// </summary>
public abstract class unclassified_Hemitriakis : Hemitriakis, Iunclassified_Hemitriakis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemitriakis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647125;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemitriakis";
}
