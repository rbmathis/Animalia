using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Pelagocephalus;

/// <summary>
/// Abstract class for Pelagocephalus (genus).
/// NCBI TaxId: 862802
/// </summary>
public abstract class Pelagocephalus : Tetraodontidae, IPelagocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelagocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862802;

    /// <inheritdoc />
    public virtual string GenusName => "Pelagocephalus";

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
