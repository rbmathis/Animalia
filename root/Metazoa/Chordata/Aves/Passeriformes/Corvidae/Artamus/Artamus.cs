using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Artamus;

/// <summary>
/// Abstract class for Artamus (genus).
/// NCBI TaxId: 175023
/// </summary>
public abstract class Artamus : Corvidae, IArtamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Artamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175023;

    /// <inheritdoc />
    public virtual string GenusName => "Artamus";

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
