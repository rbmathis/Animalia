using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Ceratoglanis;

/// <summary>
/// Abstract class for Ceratoglanis (genus).
/// NCBI TaxId: 337749
/// </summary>
public abstract class Ceratoglanis : Siluridae, ICeratoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337749;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratoglanis";

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
