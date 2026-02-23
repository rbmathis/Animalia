using AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Dinornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Dinornithidae.Dinornis;

/// <summary>
/// Abstract class for Dinornis (genus).
/// NCBI TaxId: 8817
/// </summary>
public abstract class Dinornis : Dinornithidae, IDinornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8817;

    /// <inheritdoc />
    public virtual string GenusName => "Dinornis";

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
