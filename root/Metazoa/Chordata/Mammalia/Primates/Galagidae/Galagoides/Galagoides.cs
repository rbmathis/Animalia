using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Galagoides;

/// <summary>
/// Abstract class for Galagoides (genus).
/// NCBI TaxId: 89671
/// </summary>
public abstract class Galagoides : Galagidae, IGalagoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galagoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89671;

    /// <inheritdoc />
    public virtual string GenusName => "Galagoides";

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
