using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Rhodichthys;

/// <summary>
/// Abstract class for Rhodichthys (genus).
/// NCBI TaxId: 446834
/// </summary>
public abstract class Rhodichthys : Liparidae, IRhodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446834;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodichthys";

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
