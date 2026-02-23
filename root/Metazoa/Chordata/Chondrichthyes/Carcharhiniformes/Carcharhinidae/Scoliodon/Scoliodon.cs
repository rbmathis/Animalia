using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Scoliodon;

/// <summary>
/// Abstract class for Scoliodon (genus).
/// NCBI TaxId: 7816
/// </summary>
public abstract class Scoliodon : Carcharhinidae, IScoliodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scoliodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7816;

    /// <inheritdoc />
    public virtual string GenusName => "Scoliodon";

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
