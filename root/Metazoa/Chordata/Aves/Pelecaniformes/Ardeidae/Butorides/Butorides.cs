using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Butorides;

/// <summary>
/// Abstract class for Butorides (genus).
/// NCBI TaxId: 110670
/// </summary>
public abstract class Butorides : Ardeidae, IButorides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Butorides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110670;

    /// <inheritdoc />
    public virtual string GenusName => "Butorides";

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
