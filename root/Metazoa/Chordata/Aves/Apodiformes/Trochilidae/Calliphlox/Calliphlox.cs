using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Calliphlox;

/// <summary>
/// Abstract class for Calliphlox (genus).
/// NCBI TaxId: 472783
/// </summary>
public abstract class Calliphlox : Trochilidae, ICalliphlox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calliphlox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472783;

    /// <inheritdoc />
    public virtual string GenusName => "Calliphlox";

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
