using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes.Heterodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes.Heterodontidae.Heterodontus;

/// <summary>
/// Abstract class for Heterodontus (genus).
/// NCBI TaxId: 7791
/// </summary>
public abstract class Heterodontus : Heterodontidae, IHeterodontus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterodontus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7791;

    /// <inheritdoc />
    public virtual string GenusName => "Heterodontus";

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
