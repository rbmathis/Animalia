using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Crystallichthys;

/// <summary>
/// Abstract class for Crystallichthys (genus).
/// NCBI TaxId: 446809
/// </summary>
public abstract class Crystallichthys : Liparidae, ICrystallichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crystallichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446809;

    /// <inheritdoc />
    public virtual string GenusName => "Crystallichthys";

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
