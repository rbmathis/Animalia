using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Melidectes;

/// <summary>
/// Abstract class for Melidectes (genus).
/// NCBI TaxId: 43160
/// </summary>
public abstract class Melidectes : Meliphagidae, IMelidectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melidectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43160;

    /// <inheritdoc />
    public virtual string GenusName => "Melidectes";

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
