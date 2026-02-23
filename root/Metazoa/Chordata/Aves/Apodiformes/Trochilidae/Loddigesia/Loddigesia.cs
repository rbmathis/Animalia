using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Loddigesia;

/// <summary>
/// Abstract class for Loddigesia (genus).
/// NCBI TaxId: 1507473
/// </summary>
public abstract class Loddigesia : Trochilidae, ILoddigesia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loddigesia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1507473;

    /// <inheritdoc />
    public virtual string GenusName => "Loddigesia";

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
