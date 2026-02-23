using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pseudospingus;

/// <summary>
/// Abstract class for Pseudospingus (genus).
/// NCBI TaxId: 3150849
/// </summary>
public abstract class Pseudospingus : Thraupidae, IPseudospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150849;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudospingus";

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
