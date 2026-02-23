using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Phrynoidis;

/// <summary>
/// Abstract class for Phrynoidis (genus).
/// NCBI TaxId: 651664
/// </summary>
public abstract class Phrynoidis : Bufonidae, IPhrynoidis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynoidis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651664;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynoidis";

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
