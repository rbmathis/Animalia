using AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae.Erpetoichthys;

/// <summary>
/// Abstract class for Erpetoichthys (genus).
/// NCBI TaxId: 27686
/// </summary>
public abstract class Erpetoichthys : Polypteridae, IErpetoichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erpetoichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27686;

    /// <inheritdoc />
    public virtual string GenusName => "Erpetoichthys";

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
