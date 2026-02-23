using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Nemosia;

/// <summary>
/// Abstract class for Nemosia (genus).
/// NCBI TaxId: 62222
/// </summary>
public abstract class Nemosia : Thraupidae, INemosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62222;

    /// <inheritdoc />
    public virtual string GenusName => "Nemosia";

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
