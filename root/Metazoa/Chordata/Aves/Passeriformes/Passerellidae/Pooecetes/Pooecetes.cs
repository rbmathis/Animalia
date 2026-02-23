using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Pooecetes;

/// <summary>
/// Abstract class for Pooecetes (genus).
/// NCBI TaxId: 198942
/// </summary>
public abstract class Pooecetes : Passerellidae, IPooecetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pooecetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 198942;

    /// <inheritdoc />
    public virtual string GenusName => "Pooecetes";

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
