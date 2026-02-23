using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Passerculus;

/// <summary>
/// Abstract class for Passerculus (genus).
/// NCBI TaxId: 161623
/// </summary>
public abstract class Passerculus : Passerellidae, IPasserculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Passerculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161623;

    /// <inheritdoc />
    public virtual string GenusName => "Passerculus";

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
