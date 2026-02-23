using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Pseudophichthys;

/// <summary>
/// Abstract class for Pseudophichthys (genus).
/// NCBI TaxId: 2100601
/// </summary>
public abstract class Pseudophichthys : Congridae, IPseudophichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudophichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2100601;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudophichthys";

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
