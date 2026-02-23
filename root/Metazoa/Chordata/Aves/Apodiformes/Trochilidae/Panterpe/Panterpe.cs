using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Panterpe;

/// <summary>
/// Abstract class for Panterpe (genus).
/// NCBI TaxId: 304664
/// </summary>
public abstract class Panterpe : Trochilidae, IPanterpe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Panterpe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304664;

    /// <inheritdoc />
    public virtual string GenusName => "Panterpe";

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
