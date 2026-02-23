using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Nesospingus;

/// <summary>
/// Abstract class for Nesospingus (genus).
/// NCBI TaxId: 200197
/// </summary>
public abstract class Nesospingus : Thraupidae, INesospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 200197;

    /// <inheritdoc />
    public virtual string GenusName => "Nesospingus";

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
