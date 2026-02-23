using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Abstract class for Squalus (genus).
/// NCBI TaxId: 7796
/// </summary>
public abstract class Squalus : Squalidae, ISqualus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7796;

    /// <inheritdoc />
    public virtual string GenusName => "Squalus";

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
