using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Raneya;

/// <summary>
/// Abstract class for Raneya (genus).
/// NCBI TaxId: 458604
/// </summary>
public abstract class Raneya : Ophidiidae, IRaneya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Raneya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458604;

    /// <inheritdoc />
    public virtual string GenusName => "Raneya";

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
