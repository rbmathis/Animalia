using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Apalone;

/// <summary>
/// Abstract class for Apalone (genus).
/// NCBI TaxId: 55533
/// </summary>
public abstract class Apalone : Trionychidae, IApalone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apalone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55533;

    /// <inheritdoc />
    public virtual string GenusName => "Apalone";

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
