using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Zebrilus;

/// <summary>
/// Abstract class for Zebrilus (genus).
/// NCBI TaxId: 110695
/// </summary>
public abstract class Zebrilus : Ardeidae, IZebrilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zebrilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110695;

    /// <inheritdoc />
    public virtual string GenusName => "Zebrilus";

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
