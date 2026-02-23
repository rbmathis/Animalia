using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Ptiloxena;

/// <summary>
/// Abstract class for Ptiloxena (genus).
/// NCBI TaxId: 2823194
/// </summary>
public abstract class Ptiloxena : Icteridae, IPtiloxena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptiloxena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823194;

    /// <inheritdoc />
    public virtual string GenusName => "Ptiloxena";

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
