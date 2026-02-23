using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Chaimarrornis;

/// <summary>
/// Abstract class for Chaimarrornis (genus).
/// NCBI TaxId: 358817
/// </summary>
public abstract class Chaimarrornis : Muscicapidae, IChaimarrornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaimarrornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 358817;

    /// <inheritdoc />
    public virtual string GenusName => "Chaimarrornis";

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
