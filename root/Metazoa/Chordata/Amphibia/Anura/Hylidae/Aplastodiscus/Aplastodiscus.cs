using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Aplastodiscus;

/// <summary>
/// Abstract class for Aplastodiscus (genus).
/// NCBI TaxId: 318255
/// </summary>
public abstract class Aplastodiscus : Hylidae, IAplastodiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplastodiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318255;

    /// <inheritdoc />
    public virtual string GenusName => "Aplastodiscus";

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
