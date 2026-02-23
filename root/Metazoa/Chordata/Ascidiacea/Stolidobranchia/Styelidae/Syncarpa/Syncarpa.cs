using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Syncarpa;

/// <summary>
/// Abstract class for Syncarpa (genus).
/// NCBI TaxId: 581097
/// </summary>
public abstract class Syncarpa : Styelidae, ISyncarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syncarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 581097;

    /// <inheritdoc />
    public virtual string GenusName => "Syncarpa";

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
