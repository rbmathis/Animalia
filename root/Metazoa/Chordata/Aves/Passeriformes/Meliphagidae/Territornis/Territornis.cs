using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Territornis;

/// <summary>
/// Abstract class for Territornis (genus).
/// NCBI TaxId: 3150804
/// </summary>
public abstract class Territornis : Meliphagidae, ITerritornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Territornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150804;

    /// <inheritdoc />
    public virtual string GenusName => "Territornis";

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
