using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Iniistius;

/// <summary>
/// Abstract class for Iniistius (genus).
/// NCBI TaxId: 315409
/// </summary>
public abstract class Iniistius : Labridae, IIniistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iniistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315409;

    /// <inheritdoc />
    public virtual string GenusName => "Iniistius";

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
