using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelaioides;

/// <summary>
/// Abstract class for Agelaioides (genus).
/// NCBI TaxId: 2820824
/// </summary>
public abstract class Agelaioides : Icteridae, IAgelaioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agelaioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2820824;

    /// <inheritdoc />
    public virtual string GenusName => "Agelaioides";

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
