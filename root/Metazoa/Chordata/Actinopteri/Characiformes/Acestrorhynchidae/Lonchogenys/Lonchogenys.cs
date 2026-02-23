using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae.Lonchogenys;

/// <summary>
/// Abstract class for Lonchogenys (genus).
/// NCBI TaxId: 2608215
/// </summary>
public abstract class Lonchogenys : Acestrorhynchidae, ILonchogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lonchogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608215;

    /// <inheritdoc />
    public virtual string GenusName => "Lonchogenys";

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
