using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Nasolamia;

/// <summary>
/// Abstract class for Nasolamia (genus).
/// NCBI TaxId: 671161
/// </summary>
public abstract class Nasolamia : Carcharhinidae, INasolamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nasolamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 671161;

    /// <inheritdoc />
    public virtual string GenusName => "Nasolamia";

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
