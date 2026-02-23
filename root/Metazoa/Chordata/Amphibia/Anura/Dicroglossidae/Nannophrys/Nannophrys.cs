using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Nannophrys;

/// <summary>
/// Abstract class for Nannophrys (genus).
/// NCBI TaxId: 129018
/// </summary>
public abstract class Nannophrys : Dicroglossidae, INannophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129018;

    /// <inheritdoc />
    public virtual string GenusName => "Nannophrys";

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
