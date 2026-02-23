using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mistichthys;

/// <summary>
/// Abstract class for Mistichthys (genus).
/// NCBI TaxId: 3362358
/// </summary>
public abstract class Mistichthys : Gobiidae, IMistichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mistichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362358;

    /// <inheritdoc />
    public virtual string GenusName => "Mistichthys";

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
