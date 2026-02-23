using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Taphrolesbia;

/// <summary>
/// Abstract class for Taphrolesbia (genus).
/// NCBI TaxId: 689304
/// </summary>
public abstract class Taphrolesbia : Trochilidae, ITaphrolesbia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taphrolesbia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689304;

    /// <inheritdoc />
    public virtual string GenusName => "Taphrolesbia";

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
