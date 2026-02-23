using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Pusa;

/// <summary>
/// Abstract class for Pusa (genus).
/// NCBI TaxId: 693430
/// </summary>
public abstract class Pusa : Phocidae, IPusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 693430;

    /// <inheritdoc />
    public virtual string GenusName => "Pusa";

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
