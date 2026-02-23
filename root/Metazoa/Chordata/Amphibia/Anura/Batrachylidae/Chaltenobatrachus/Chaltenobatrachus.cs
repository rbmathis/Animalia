using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Chaltenobatrachus;

/// <summary>
/// Abstract class for Chaltenobatrachus (genus).
/// NCBI TaxId: 1302429
/// </summary>
public abstract class Chaltenobatrachus : Batrachylidae, IChaltenobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaltenobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1302429;

    /// <inheritdoc />
    public virtual string GenusName => "Chaltenobatrachus";

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
