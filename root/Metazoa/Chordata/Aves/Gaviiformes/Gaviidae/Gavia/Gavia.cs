using AnimalKingdom.root.Metazoa.Chordata.Aves.Gaviiformes.Gaviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gaviiformes.Gaviidae.Gavia;

/// <summary>
/// Abstract class for Gavia (genus).
/// NCBI TaxId: 37038
/// </summary>
public abstract class Gavia : Gaviidae, IGavia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gavia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37038;

    /// <inheritdoc />
    public virtual string GenusName => "Gavia";

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
