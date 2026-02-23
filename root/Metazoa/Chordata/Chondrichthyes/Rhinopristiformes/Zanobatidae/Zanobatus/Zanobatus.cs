using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Zanobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Zanobatidae.Zanobatus;

/// <summary>
/// Abstract class for Zanobatus (genus).
/// NCBI TaxId: 117846
/// </summary>
public abstract class Zanobatus : Zanobatidae, IZanobatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zanobatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117846;

    /// <inheritdoc />
    public virtual string GenusName => "Zanobatus";

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
