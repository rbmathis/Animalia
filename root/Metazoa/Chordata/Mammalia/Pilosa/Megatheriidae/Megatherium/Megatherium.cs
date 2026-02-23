using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megatheriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megatheriidae.Megatherium;

/// <summary>
/// Abstract class for Megatherium (genus).
/// NCBI TaxId: 2546650
/// </summary>
public abstract class Megatherium : Megatheriidae, IMegatherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megatherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546650;

    /// <inheritdoc />
    public virtual string GenusName => "Megatherium";

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
