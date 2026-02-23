using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Arctodus;

/// <summary>
/// Abstract class for Arctodus (genus).
/// NCBI TaxId: 544298
/// </summary>
public abstract class Arctodus : Ursidae, IArctodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 544298;

    /// <inheritdoc />
    public virtual string GenusName => "Arctodus";

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
