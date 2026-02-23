using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Potamorhina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Potamorhina.unclassified_Potamorhina;

/// <summary>
/// Abstract class for unclassified Potamorhina (no rank).
/// NCBI TaxId: 2634518
/// </summary>
public abstract class unclassified_Potamorhina : Potamorhina, Iunclassified_Potamorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Potamorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634518;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Potamorhina";
}
