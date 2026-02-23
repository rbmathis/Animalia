using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Pyrrhurus;

/// <summary>
/// Abstract class for Pyrrhurus (genus).
/// NCBI TaxId: 447946
/// </summary>
public abstract class Pyrrhurus : Pycnonotidae, IPyrrhurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 447946;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhurus";

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
