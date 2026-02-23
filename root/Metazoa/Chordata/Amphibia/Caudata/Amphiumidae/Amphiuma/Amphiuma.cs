using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Amphiumidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Amphiumidae.Amphiuma;

/// <summary>
/// Abstract class for Amphiuma (genus).
/// NCBI TaxId: 8311
/// </summary>
public abstract class Amphiuma : Amphiumidae, IAmphiuma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphiuma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8311;

    /// <inheritdoc />
    public virtual string GenusName => "Amphiuma";

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
