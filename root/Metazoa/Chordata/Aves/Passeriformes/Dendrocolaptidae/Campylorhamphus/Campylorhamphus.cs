using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Campylorhamphus;

/// <summary>
/// Abstract class for Campylorhamphus (genus).
/// NCBI TaxId: 190294
/// </summary>
public abstract class Campylorhamphus : Dendrocolaptidae, ICampylorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campylorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190294;

    /// <inheritdoc />
    public virtual string GenusName => "Campylorhamphus";

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
