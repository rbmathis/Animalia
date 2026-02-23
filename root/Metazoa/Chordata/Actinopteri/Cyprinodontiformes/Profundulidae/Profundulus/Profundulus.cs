using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae.Profundulus;

/// <summary>
/// Abstract class for Profundulus (genus).
/// NCBI TaxId: 28769
/// </summary>
public abstract class Profundulus : Profundulidae, IProfundulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Profundulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28769;

    /// <inheritdoc />
    public virtual string GenusName => "Profundulus";

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
