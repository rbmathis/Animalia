using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Phaeoptila;

/// <summary>
/// Abstract class for Phaeoptila (genus).
/// NCBI TaxId: 3043773
/// </summary>
public abstract class Phaeoptila : Trochilidae, IPhaeoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaeoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3043773;

    /// <inheritdoc />
    public virtual string GenusName => "Phaeoptila";

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
