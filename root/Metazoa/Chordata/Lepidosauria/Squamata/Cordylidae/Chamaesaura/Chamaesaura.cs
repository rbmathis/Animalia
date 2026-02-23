using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Chamaesaura;

/// <summary>
/// Abstract class for Chamaesaura (genus).
/// NCBI TaxId: 126627
/// </summary>
public abstract class Chamaesaura : Cordylidae, IChamaesaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chamaesaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126627;

    /// <inheritdoc />
    public virtual string GenusName => "Chamaesaura";

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
