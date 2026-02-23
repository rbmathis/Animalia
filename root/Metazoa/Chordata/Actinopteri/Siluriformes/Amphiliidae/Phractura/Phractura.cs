using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Phractura;

/// <summary>
/// Abstract class for Phractura (genus).
/// NCBI TaxId: 390405
/// </summary>
public abstract class Phractura : Amphiliidae, IPhractura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phractura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390405;

    /// <inheritdoc />
    public virtual string GenusName => "Phractura";

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
