using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Poromera;

/// <summary>
/// Abstract class for Poromera (genus).
/// NCBI TaxId: 80457
/// </summary>
public abstract class Poromera : Lacertidae, IPoromera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poromera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80457;

    /// <inheritdoc />
    public virtual string GenusName => "Poromera";

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
