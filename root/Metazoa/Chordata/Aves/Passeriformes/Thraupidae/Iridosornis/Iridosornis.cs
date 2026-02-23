using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Iridosornis;

/// <summary>
/// Abstract class for Iridosornis (genus).
/// NCBI TaxId: 62211
/// </summary>
public abstract class Iridosornis : Thraupidae, IIridosornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iridosornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62211;

    /// <inheritdoc />
    public virtual string GenusName => "Iridosornis";

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
