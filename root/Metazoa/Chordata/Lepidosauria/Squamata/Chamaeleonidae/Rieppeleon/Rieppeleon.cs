using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Rieppeleon;

/// <summary>
/// Abstract class for Rieppeleon (genus).
/// NCBI TaxId: 338554
/// </summary>
public abstract class Rieppeleon : Chamaeleonidae, IRieppeleon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rieppeleon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338554;

    /// <inheritdoc />
    public virtual string GenusName => "Rieppeleon";

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
