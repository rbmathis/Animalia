using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Calothorax;

/// <summary>
/// Abstract class for Calothorax (genus).
/// NCBI TaxId: 240705
/// </summary>
public abstract class Calothorax : Trochilidae, ICalothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240705;

    /// <inheritdoc />
    public virtual string GenusName => "Calothorax";

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
