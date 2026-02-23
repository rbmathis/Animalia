using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Coggerdonia;

/// <summary>
/// Abstract class for Coggerdonia (genus).
/// NCBI TaxId: 3680987
/// </summary>
public abstract class Coggerdonia : Pelodryadidae, ICoggerdonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coggerdonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680987;

    /// <inheritdoc />
    public virtual string GenusName => "Coggerdonia";

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
