using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Tympanocryptis;

/// <summary>
/// Abstract class for Tympanocryptis (genus).
/// NCBI TaxId: 118243
/// </summary>
public abstract class Tympanocryptis : Agamidae, ITympanocryptis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tympanocryptis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118243;

    /// <inheritdoc />
    public virtual string GenusName => "Tympanocryptis";

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
