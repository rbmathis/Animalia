using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Lophospingus;

/// <summary>
/// Abstract class for Lophospingus (genus).
/// NCBI TaxId: 357705
/// </summary>
public abstract class Lophospingus : Thraupidae, ILophospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 357705;

    /// <inheritdoc />
    public virtual string GenusName => "Lophospingus";

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
