using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Birdsongichthys;

/// <summary>
/// Abstract class for Birdsongichthys (genus).
/// NCBI TaxId: 2994269
/// </summary>
public abstract class Birdsongichthys : Gobiidae, IBirdsongichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Birdsongichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2994269;

    /// <inheritdoc />
    public virtual string GenusName => "Birdsongichthys";

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
