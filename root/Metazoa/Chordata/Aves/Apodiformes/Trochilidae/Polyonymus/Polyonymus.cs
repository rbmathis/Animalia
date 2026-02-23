using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Polyonymus;

/// <summary>
/// Abstract class for Polyonymus (genus).
/// NCBI TaxId: 689269
/// </summary>
public abstract class Polyonymus : Trochilidae, IPolyonymus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyonymus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689269;

    /// <inheritdoc />
    public virtual string GenusName => "Polyonymus";

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
