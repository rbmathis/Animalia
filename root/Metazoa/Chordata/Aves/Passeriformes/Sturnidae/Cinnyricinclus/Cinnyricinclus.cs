using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Cinnyricinclus;

/// <summary>
/// Abstract class for Cinnyricinclus (genus).
/// NCBI TaxId: 245050
/// </summary>
public abstract class Cinnyricinclus : Sturnidae, ICinnyricinclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinnyricinclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245050;

    /// <inheritdoc />
    public virtual string GenusName => "Cinnyricinclus";

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
