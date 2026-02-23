using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Avocettula;

/// <summary>
/// Abstract class for Avocettula (genus).
/// NCBI TaxId: 584666
/// </summary>
public abstract class Avocettula : Trochilidae, IAvocettula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Avocettula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 584666;

    /// <inheritdoc />
    public virtual string GenusName => "Avocettula";

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
