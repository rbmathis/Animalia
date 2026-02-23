using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Triaenodon;

/// <summary>
/// Abstract class for Triaenodon (genus).
/// NCBI TaxId: 496412
/// </summary>
public abstract class Triaenodon : Carcharhinidae, ITriaenodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triaenodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496412;

    /// <inheritdoc />
    public virtual string GenusName => "Triaenodon";

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
