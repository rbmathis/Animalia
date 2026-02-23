using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Tampichthys;

/// <summary>
/// Abstract class for Tampichthys (genus).
/// NCBI TaxId: 479125
/// </summary>
public abstract class Tampichthys : Leuciscidae, ITampichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tampichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 479125;

    /// <inheritdoc />
    public virtual string GenusName => "Tampichthys";

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
