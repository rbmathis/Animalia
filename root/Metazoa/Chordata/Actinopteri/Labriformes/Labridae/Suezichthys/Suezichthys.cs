using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Suezichthys;

/// <summary>
/// Abstract class for Suezichthys (genus).
/// NCBI TaxId: 242815
/// </summary>
public abstract class Suezichthys : Labridae, ISuezichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suezichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242815;

    /// <inheritdoc />
    public virtual string GenusName => "Suezichthys";

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
