using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aythya;

/// <summary>
/// Abstract class for Aythya (genus).
/// NCBI TaxId: 30384
/// </summary>
public abstract class Aythya : Anatidae, IAythya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aythya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30384;

    /// <inheritdoc />
    public virtual string GenusName => "Aythya";

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
