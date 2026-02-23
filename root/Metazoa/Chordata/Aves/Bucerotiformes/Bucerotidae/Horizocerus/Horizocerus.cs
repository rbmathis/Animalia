using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Horizocerus;

/// <summary>
/// Abstract class for Horizocerus (genus).
/// NCBI TaxId: 3150777
/// </summary>
public abstract class Horizocerus : Bucerotidae, IHorizocerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Horizocerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150777;

    /// <inheritdoc />
    public virtual string GenusName => "Horizocerus";

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
