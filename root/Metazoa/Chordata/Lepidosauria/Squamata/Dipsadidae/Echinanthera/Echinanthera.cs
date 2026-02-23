using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Echinanthera;

/// <summary>
/// Abstract class for Echinanthera (genus).
/// NCBI TaxId: 758876
/// </summary>
public abstract class Echinanthera : Dipsadidae, IEchinanthera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinanthera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758876;

    /// <inheritdoc />
    public virtual string GenusName => "Echinanthera";

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
