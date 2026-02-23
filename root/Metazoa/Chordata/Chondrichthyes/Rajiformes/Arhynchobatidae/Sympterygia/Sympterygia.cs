using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Sympterygia;

/// <summary>
/// Abstract class for Sympterygia (genus).
/// NCBI TaxId: 117878
/// </summary>
public abstract class Sympterygia : Arhynchobatidae, ISympterygia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sympterygia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117878;

    /// <inheritdoc />
    public virtual string GenusName => "Sympterygia";

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
