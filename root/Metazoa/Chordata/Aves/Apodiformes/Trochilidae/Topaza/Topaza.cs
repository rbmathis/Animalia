using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Topaza;

/// <summary>
/// Abstract class for Topaza (genus).
/// NCBI TaxId: 304689
/// </summary>
public abstract class Topaza : Trochilidae, ITopaza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Topaza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304689;

    /// <inheritdoc />
    public virtual string GenusName => "Topaza";

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
