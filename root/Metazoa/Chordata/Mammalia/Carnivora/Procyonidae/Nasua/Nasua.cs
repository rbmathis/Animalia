using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasua;

/// <summary>
/// Abstract class for Nasua (genus).
/// NCBI TaxId: 9650
/// </summary>
public abstract class Nasua : Procyonidae, INasua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nasua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9650;

    /// <inheritdoc />
    public virtual string GenusName => "Nasua";

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
