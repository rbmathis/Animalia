using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Monomitopus;

/// <summary>
/// Abstract class for Monomitopus (genus).
/// NCBI TaxId: 1812883
/// </summary>
public abstract class Monomitopus : Ophidiidae, IMonomitopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monomitopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1812883;

    /// <inheritdoc />
    public virtual string GenusName => "Monomitopus";

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
