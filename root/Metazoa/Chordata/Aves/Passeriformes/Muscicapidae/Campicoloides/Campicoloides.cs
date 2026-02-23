using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Campicoloides;

/// <summary>
/// Abstract class for Campicoloides (genus).
/// NCBI TaxId: 757452
/// </summary>
public abstract class Campicoloides : Muscicapidae, ICampicoloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campicoloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 757452;

    /// <inheritdoc />
    public virtual string GenusName => "Campicoloides";

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
