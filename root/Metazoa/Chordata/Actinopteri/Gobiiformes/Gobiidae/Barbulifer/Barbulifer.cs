using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Barbulifer;

/// <summary>
/// Abstract class for Barbulifer (genus).
/// NCBI TaxId: 166733
/// </summary>
public abstract class Barbulifer : Gobiidae, IBarbulifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbulifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166733;

    /// <inheritdoc />
    public virtual string GenusName => "Barbulifer";

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
