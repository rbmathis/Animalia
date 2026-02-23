using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Spilocuscus;

/// <summary>
/// Abstract class for Spilocuscus (genus).
/// NCBI TaxId: 114228
/// </summary>
public abstract class Spilocuscus : Phalangeridae, ISpilocuscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spilocuscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114228;

    /// <inheritdoc />
    public virtual string GenusName => "Spilocuscus";

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
