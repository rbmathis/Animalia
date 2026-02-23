using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Xenospingus;

/// <summary>
/// Abstract class for Xenospingus (genus).
/// NCBI TaxId: 1226245
/// </summary>
public abstract class Xenospingus : Thraupidae, IXenospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1226245;

    /// <inheritdoc />
    public virtual string GenusName => "Xenospingus";

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
