using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Oreosaurus;

/// <summary>
/// Abstract class for Oreosaurus (genus).
/// NCBI TaxId: 2027778
/// </summary>
public abstract class Oreosaurus : Gymnophthalmidae, IOreosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2027778;

    /// <inheritdoc />
    public virtual string GenusName => "Oreosaurus";

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
