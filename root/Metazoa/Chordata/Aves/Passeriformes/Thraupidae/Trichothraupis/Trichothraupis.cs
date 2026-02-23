using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Trichothraupis;

/// <summary>
/// Abstract class for Trichothraupis (genus).
/// NCBI TaxId: 555362
/// </summary>
public abstract class Trichothraupis : Thraupidae, ITrichothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555362;

    /// <inheritdoc />
    public virtual string GenusName => "Trichothraupis";

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
