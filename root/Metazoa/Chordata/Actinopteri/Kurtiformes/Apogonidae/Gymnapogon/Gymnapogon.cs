using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Gymnapogon;

/// <summary>
/// Abstract class for Gymnapogon (genus).
/// NCBI TaxId: 475180
/// </summary>
public abstract class Gymnapogon : Apogonidae, IGymnapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 475180;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnapogon";

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
