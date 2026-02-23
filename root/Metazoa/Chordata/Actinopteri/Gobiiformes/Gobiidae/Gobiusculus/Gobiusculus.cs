using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiusculus;

/// <summary>
/// Abstract class for Gobiusculus (genus).
/// NCBI TaxId: 257539
/// </summary>
public abstract class Gobiusculus : Gobiidae, IGobiusculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobiusculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257539;

    /// <inheritdoc />
    public virtual string GenusName => "Gobiusculus";

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
