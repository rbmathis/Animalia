using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Bolborhynchus;

/// <summary>
/// Abstract class for Bolborhynchus (genus).
/// NCBI TaxId: 211876
/// </summary>
public abstract class Bolborhynchus : Psittacidae, IBolborhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bolborhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 211876;

    /// <inheritdoc />
    public virtual string GenusName => "Bolborhynchus";

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
