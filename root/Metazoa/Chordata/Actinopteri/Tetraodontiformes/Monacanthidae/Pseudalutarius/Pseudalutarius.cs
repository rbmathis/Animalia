using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pseudalutarius;

/// <summary>
/// Abstract class for Pseudalutarius (genus).
/// NCBI TaxId: 392928
/// </summary>
public abstract class Pseudalutarius : Monacanthidae, IPseudalutarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudalutarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392928;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudalutarius";

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
