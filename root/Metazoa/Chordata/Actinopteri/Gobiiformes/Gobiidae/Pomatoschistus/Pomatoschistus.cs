using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pomatoschistus;

/// <summary>
/// Abstract class for Pomatoschistus (genus).
/// NCBI TaxId: 13224
/// </summary>
public abstract class Pomatoschistus : Gobiidae, IPomatoschistus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomatoschistus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13224;

    /// <inheritdoc />
    public virtual string GenusName => "Pomatoschistus";

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
