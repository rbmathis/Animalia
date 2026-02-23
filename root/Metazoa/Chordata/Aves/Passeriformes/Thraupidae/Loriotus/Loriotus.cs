using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Loriotus;

/// <summary>
/// Abstract class for Loriotus (genus).
/// NCBI TaxId: 3150843
/// </summary>
public abstract class Loriotus : Thraupidae, ILoriotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loriotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150843;

    /// <inheritdoc />
    public virtual string GenusName => "Loriotus";

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
