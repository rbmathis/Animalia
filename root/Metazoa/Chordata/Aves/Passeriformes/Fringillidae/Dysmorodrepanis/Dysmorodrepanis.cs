using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Dysmorodrepanis;

/// <summary>
/// Abstract class for Dysmorodrepanis (genus).
/// NCBI TaxId: 3036911
/// </summary>
public abstract class Dysmorodrepanis : Fringillidae, IDysmorodrepanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dysmorodrepanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3036911;

    /// <inheritdoc />
    public virtual string GenusName => "Dysmorodrepanis";

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
