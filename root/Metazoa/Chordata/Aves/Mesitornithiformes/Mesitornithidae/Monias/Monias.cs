using AnimalKingdom.root.Metazoa.Chordata.Aves.Mesitornithiformes.Mesitornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Mesitornithiformes.Mesitornithidae.Monias;

/// <summary>
/// Abstract class for Monias (genus).
/// NCBI TaxId: 399592
/// </summary>
public abstract class Monias : Mesitornithidae, IMonias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399592;

    /// <inheritdoc />
    public virtual string GenusName => "Monias";

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
