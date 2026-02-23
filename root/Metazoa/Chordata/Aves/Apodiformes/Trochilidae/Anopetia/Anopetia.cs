using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Anopetia;

/// <summary>
/// Abstract class for Anopetia (genus).
/// NCBI TaxId: 1109022
/// </summary>
public abstract class Anopetia : Trochilidae, IAnopetia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anopetia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109022;

    /// <inheritdoc />
    public virtual string GenusName => "Anopetia";

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
