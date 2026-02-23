using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Eutoxeres;

/// <summary>
/// Abstract class for Eutoxeres (genus).
/// NCBI TaxId: 190685
/// </summary>
public abstract class Eutoxeres : Trochilidae, IEutoxeres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutoxeres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190685;

    /// <inheritdoc />
    public virtual string GenusName => "Eutoxeres";

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
