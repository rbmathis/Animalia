using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chalcostigma;

/// <summary>
/// Abstract class for Chalcostigma (genus).
/// NCBI TaxId: 66415
/// </summary>
public abstract class Chalcostigma : Trochilidae, IChalcostigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcostigma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66415;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcostigma";

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
