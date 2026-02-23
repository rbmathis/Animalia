using AnimalKingdom.root.Metazoa.Chordata.Aves.Mesitornithiformes.Mesitornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Mesitornithiformes.Mesitornithidae.Mesitornis;

/// <summary>
/// Abstract class for Mesitornis (genus).
/// NCBI TaxId: 54373
/// </summary>
public abstract class Mesitornis : Mesitornithidae, IMesitornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesitornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54373;

    /// <inheritdoc />
    public virtual string GenusName => "Mesitornis";

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
