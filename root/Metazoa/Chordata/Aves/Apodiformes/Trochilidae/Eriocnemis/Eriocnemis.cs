using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Eriocnemis;

/// <summary>
/// Abstract class for Eriocnemis (genus).
/// NCBI TaxId: 56652
/// </summary>
public abstract class Eriocnemis : Trochilidae, IEriocnemis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eriocnemis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56652;

    /// <inheritdoc />
    public virtual string GenusName => "Eriocnemis";

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
