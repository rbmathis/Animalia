using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Adrianichthyidae.Oryzias;

/// <summary>
/// Abstract class for Oryzias (genus).
/// NCBI TaxId: 8089
/// </summary>
public abstract class Oryzias : Adrianichthyidae, IOryzias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oryzias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8089;

    /// <inheritdoc />
    public virtual string GenusName => "Oryzias";

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
