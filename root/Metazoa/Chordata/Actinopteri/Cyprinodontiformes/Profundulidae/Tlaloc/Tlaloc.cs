using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Profundulidae.Tlaloc;

/// <summary>
/// Abstract class for Tlaloc (genus).
/// NCBI TaxId: 3061059
/// </summary>
public abstract class Tlaloc : Profundulidae, ITlaloc
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tlaloc";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3061059;

    /// <inheritdoc />
    public virtual string GenusName => "Tlaloc";

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
