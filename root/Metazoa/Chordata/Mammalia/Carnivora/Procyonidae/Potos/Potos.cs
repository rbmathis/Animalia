using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Potos;

/// <summary>
/// Abstract class for Potos (genus).
/// NCBI TaxId: 29066
/// </summary>
public abstract class Potos : Procyonidae, IPotos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29066;

    /// <inheritdoc />
    public virtual string GenusName => "Potos";

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
