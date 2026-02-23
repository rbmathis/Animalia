using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus;

/// <summary>
/// Abstract class for Osteocephalus (genus).
/// NCBI TaxId: 152498
/// </summary>
public abstract class Osteocephalus : Hylidae, IOsteocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 152498;

    /// <inheritdoc />
    public virtual string GenusName => "Osteocephalus";

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
