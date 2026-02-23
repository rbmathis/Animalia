using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Dotsugobius;

/// <summary>
/// Abstract class for Dotsugobius (genus).
/// NCBI TaxId: 3040462
/// </summary>
public abstract class Dotsugobius : Gobiidae, IDotsugobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dotsugobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040462;

    /// <inheritdoc />
    public virtual string GenusName => "Dotsugobius";

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
