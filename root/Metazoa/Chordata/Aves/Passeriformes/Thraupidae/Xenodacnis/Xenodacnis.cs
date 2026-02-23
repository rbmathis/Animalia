using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Xenodacnis;

/// <summary>
/// Abstract class for Xenodacnis (genus).
/// NCBI TaxId: 62260
/// </summary>
public abstract class Xenodacnis : Thraupidae, IXenodacnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenodacnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62260;

    /// <inheritdoc />
    public virtual string GenusName => "Xenodacnis";

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
