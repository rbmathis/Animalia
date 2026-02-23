using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Tuamotuichthys;

/// <summary>
/// Abstract class for Tuamotuichthys (genus).
/// NCBI TaxId: 1843777
/// </summary>
public abstract class Tuamotuichthys : Bythitidae, ITuamotuichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tuamotuichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843777;

    /// <inheritdoc />
    public virtual string GenusName => "Tuamotuichthys";

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
