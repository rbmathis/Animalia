using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Dendrophryniscus;

/// <summary>
/// Abstract class for Dendrophryniscus (genus).
/// NCBI TaxId: 164280
/// </summary>
public abstract class Dendrophryniscus : Bufonidae, IDendrophryniscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrophryniscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164280;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrophryniscus";

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
