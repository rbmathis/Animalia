using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Potamosilurus;

/// <summary>
/// Abstract class for Potamosilurus (genus).
/// NCBI TaxId: 591333
/// </summary>
public abstract class Potamosilurus : Ariidae, IPotamosilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamosilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591333;

    /// <inheritdoc />
    public virtual string GenusName => "Potamosilurus";

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
