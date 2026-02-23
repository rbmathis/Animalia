using AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoeniconaias;

/// <summary>
/// Abstract class for Phoeniconaias (genus).
/// NCBI TaxId: 2839957
/// </summary>
public abstract class Phoeniconaias : Phoenicopteridae, IPhoeniconaias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoeniconaias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2839957;

    /// <inheritdoc />
    public virtual string GenusName => "Phoeniconaias";

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
