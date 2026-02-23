using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Herpestes;

/// <summary>
/// Abstract class for Herpestes (genus).
/// NCBI TaxId: 9699
/// </summary>
public abstract class Herpestes : Herpestidae, IHerpestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herpestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9699;

    /// <inheritdoc />
    public virtual string GenusName => "Herpestes";

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
