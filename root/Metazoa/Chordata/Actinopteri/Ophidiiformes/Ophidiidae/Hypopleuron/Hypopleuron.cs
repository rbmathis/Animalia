using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Hypopleuron;

/// <summary>
/// Abstract class for Hypopleuron (genus).
/// NCBI TaxId: 3056622
/// </summary>
public abstract class Hypopleuron : Ophidiidae, IHypopleuron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypopleuron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3056622;

    /// <inheritdoc />
    public virtual string GenusName => "Hypopleuron";

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
