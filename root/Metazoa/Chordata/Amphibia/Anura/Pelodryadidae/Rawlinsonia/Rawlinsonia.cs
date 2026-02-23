using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Rawlinsonia;

/// <summary>
/// Abstract class for Rawlinsonia (genus).
/// NCBI TaxId: 3681004
/// </summary>
public abstract class Rawlinsonia : Pelodryadidae, IRawlinsonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rawlinsonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681004;

    /// <inheritdoc />
    public virtual string GenusName => "Rawlinsonia";

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
