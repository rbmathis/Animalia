using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Onychostruthus;

/// <summary>
/// Abstract class for Onychostruthus (genus).
/// NCBI TaxId: 2823048
/// </summary>
public abstract class Onychostruthus : Passeridae, IOnychostruthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Onychostruthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823048;

    /// <inheritdoc />
    public virtual string GenusName => "Onychostruthus";

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
