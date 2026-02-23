using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Barathrites;

/// <summary>
/// Abstract class for Barathrites (genus).
/// NCBI TaxId: 3362464
/// </summary>
public abstract class Barathrites : Ophidiidae, IBarathrites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barathrites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362464;

    /// <inheritdoc />
    public virtual string GenusName => "Barathrites";

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
