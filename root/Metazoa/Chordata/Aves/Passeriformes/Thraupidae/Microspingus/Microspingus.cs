using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Microspingus;

/// <summary>
/// Abstract class for Microspingus (genus).
/// NCBI TaxId: 2692229
/// </summary>
public abstract class Microspingus : Thraupidae, IMicrospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microspingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2692229;

    /// <inheritdoc />
    public virtual string GenusName => "Microspingus";

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
