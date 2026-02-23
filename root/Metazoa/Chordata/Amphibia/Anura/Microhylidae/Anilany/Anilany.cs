using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Anilany;

/// <summary>
/// Abstract class for Anilany (genus).
/// NCBI TaxId: 1837980
/// </summary>
public abstract class Anilany : Microhylidae, IAnilany
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anilany";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1837980;

    /// <inheritdoc />
    public virtual string GenusName => "Anilany";

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
