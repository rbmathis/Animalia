using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Irolita;

/// <summary>
/// Abstract class for Irolita (genus).
/// NCBI TaxId: 117871
/// </summary>
public abstract class Irolita : Arhynchobatidae, IIrolita
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Irolita";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117871;

    /// <inheritdoc />
    public virtual string GenusName => "Irolita";

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
