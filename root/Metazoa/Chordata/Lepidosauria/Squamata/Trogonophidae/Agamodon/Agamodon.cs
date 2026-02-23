using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Trogonophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Trogonophidae.Agamodon;

/// <summary>
/// Abstract class for Agamodon (genus).
/// NCBI TaxId: 261489
/// </summary>
public abstract class Agamodon : Trogonophidae, IAgamodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agamodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261489;

    /// <inheritdoc />
    public virtual string GenusName => "Agamodon";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
