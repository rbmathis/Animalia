using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Potamorhina;

/// <summary>
/// Abstract class for Potamorhina (genus).
/// NCBI TaxId: 143036
/// </summary>
public abstract class Potamorhina : Curimatidae, IPotamorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143036;

    /// <inheritdoc />
    public virtual string GenusName => "Potamorhina";

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
