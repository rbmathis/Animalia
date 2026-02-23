using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Rhyaconastes;

/// <summary>
/// Abstract class for Rhyaconastes (genus).
/// NCBI TaxId: 3681005
/// </summary>
public abstract class Rhyaconastes : Pelodryadidae, IRhyaconastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhyaconastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681005;

    /// <inheritdoc />
    public virtual string GenusName => "Rhyaconastes";

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
