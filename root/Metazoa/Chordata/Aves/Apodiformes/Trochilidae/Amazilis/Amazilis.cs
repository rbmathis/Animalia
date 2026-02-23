using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Amazilis;

/// <summary>
/// Abstract class for Amazilis (genus).
/// NCBI TaxId: 3150855
/// </summary>
public abstract class Amazilis : Trochilidae, IAmazilis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amazilis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150855;

    /// <inheritdoc />
    public virtual string GenusName => "Amazilis";

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
