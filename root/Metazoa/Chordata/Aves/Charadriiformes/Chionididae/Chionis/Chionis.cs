using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Chionididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Chionididae.Chionis;

/// <summary>
/// Abstract class for Chionis (genus).
/// NCBI TaxId: 227181
/// </summary>
public abstract class Chionis : Chionididae, IChionis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chionis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227181;

    /// <inheritdoc />
    public virtual string GenusName => "Chionis";

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
