using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Volatinia;

/// <summary>
/// Abstract class for Volatinia (genus).
/// NCBI TaxId: 135451
/// </summary>
public abstract class Volatinia : Thraupidae, IVolatinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Volatinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135451;

    /// <inheritdoc />
    public virtual string GenusName => "Volatinia";

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
