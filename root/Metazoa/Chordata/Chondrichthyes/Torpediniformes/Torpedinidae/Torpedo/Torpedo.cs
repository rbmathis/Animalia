using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Abstract class for Torpedo (genus).
/// NCBI TaxId: 7786
/// </summary>
public abstract class Torpedo : Torpedinidae, ITorpedo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Torpedo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7786;

    /// <inheritdoc />
    public virtual string GenusName => "Torpedo";

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
