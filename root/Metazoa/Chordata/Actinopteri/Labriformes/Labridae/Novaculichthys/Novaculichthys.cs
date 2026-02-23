using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Novaculichthys;

/// <summary>
/// Abstract class for Novaculichthys (genus).
/// NCBI TaxId: 241322
/// </summary>
public abstract class Novaculichthys : Labridae, INovaculichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Novaculichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241322;

    /// <inheritdoc />
    public virtual string GenusName => "Novaculichthys";

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
