using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Morchellium;

/// <summary>
/// Abstract class for Morchellium (genus).
/// NCBI TaxId: 1440459
/// </summary>
public abstract class Morchellium : Polyclinidae, IMorchellium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morchellium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1440459;

    /// <inheritdoc />
    public virtual string GenusName => "Morchellium";

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
