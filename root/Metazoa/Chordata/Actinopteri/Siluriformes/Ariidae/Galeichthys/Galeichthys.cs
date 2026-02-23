using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Galeichthys;

/// <summary>
/// Abstract class for Galeichthys (genus).
/// NCBI TaxId: 390434
/// </summary>
public abstract class Galeichthys : Ariidae, IGaleichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galeichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390434;

    /// <inheritdoc />
    public virtual string GenusName => "Galeichthys";

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
