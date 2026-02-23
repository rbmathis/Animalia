using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Polytmus;

/// <summary>
/// Abstract class for Polytmus (genus).
/// NCBI TaxId: 472908
/// </summary>
public abstract class Polytmus : Trochilidae, IPolytmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polytmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472908;

    /// <inheritdoc />
    public virtual string GenusName => "Polytmus";

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
