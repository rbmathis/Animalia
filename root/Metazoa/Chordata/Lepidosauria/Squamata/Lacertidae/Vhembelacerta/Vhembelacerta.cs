using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Vhembelacerta;

/// <summary>
/// Abstract class for Vhembelacerta (genus).
/// NCBI TaxId: 1538140
/// </summary>
public abstract class Vhembelacerta : Lacertidae, IVhembelacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vhembelacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1538140;

    /// <inheritdoc />
    public virtual string GenusName => "Vhembelacerta";

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
