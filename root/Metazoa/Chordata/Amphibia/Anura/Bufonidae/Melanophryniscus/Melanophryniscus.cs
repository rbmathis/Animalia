using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Melanophryniscus;

/// <summary>
/// Abstract class for Melanophryniscus (genus).
/// NCBI TaxId: 47581
/// </summary>
public abstract class Melanophryniscus : Bufonidae, IMelanophryniscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanophryniscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47581;

    /// <inheritdoc />
    public virtual string GenusName => "Melanophryniscus";

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
