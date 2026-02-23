using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae.Necturus;

/// <summary>
/// Abstract class for Necturus (genus).
/// NCBI TaxId: 42756
/// </summary>
public abstract class Necturus : Proteidae, INecturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Necturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42756;

    /// <inheritdoc />
    public virtual string GenusName => "Necturus";

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
