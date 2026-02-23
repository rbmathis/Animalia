using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Pelobatrachus;

/// <summary>
/// Abstract class for Pelobatrachus (genus).
/// NCBI TaxId: 2951161
/// </summary>
public abstract class Pelobatrachus : Megophryidae, IPelobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2951161;

    /// <inheritdoc />
    public virtual string GenusName => "Pelobatrachus";

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
