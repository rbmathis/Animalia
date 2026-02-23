using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Benthophilus;

/// <summary>
/// Abstract class for Benthophilus (genus).
/// NCBI TaxId: 446519
/// </summary>
public abstract class Benthophilus : Gobiidae, IBenthophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446519;

    /// <inheritdoc />
    public virtual string GenusName => "Benthophilus";

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
