using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Akialoa;

/// <summary>
/// Abstract class for Akialoa (genus).
/// NCBI TaxId: 1804738
/// </summary>
public abstract class Akialoa : Fringillidae, IAkialoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Akialoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1804738;

    /// <inheritdoc />
    public virtual string GenusName => "Akialoa";

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
