using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Benthobatis;

/// <summary>
/// Abstract class for Benthobatis (genus).
/// NCBI TaxId: 1154677
/// </summary>
public abstract class Benthobatis : Narcinidae, IBenthobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1154677;

    /// <inheritdoc />
    public virtual string GenusName => "Benthobatis";

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
