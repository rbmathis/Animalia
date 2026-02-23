using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Myrmia;

/// <summary>
/// Abstract class for Myrmia (genus).
/// NCBI TaxId: 689231
/// </summary>
public abstract class Myrmia : Trochilidae, IMyrmia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689231;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmia";

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
