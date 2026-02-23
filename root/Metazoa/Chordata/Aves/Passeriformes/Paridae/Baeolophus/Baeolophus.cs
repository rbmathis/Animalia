using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Baeolophus;

/// <summary>
/// Abstract class for Baeolophus (genus).
/// NCBI TaxId: 88113
/// </summary>
public abstract class Baeolophus : Paridae, IBaeolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Baeolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88113;

    /// <inheritdoc />
    public virtual string GenusName => "Baeolophus";

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
